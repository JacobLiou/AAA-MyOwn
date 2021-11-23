﻿using Microsoft.Win32;

namespace ThisIsWin11.PumpedApp.Assessment.Gaming
{
    internal class PowerThrottling : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Power\PowerThrottling";
        private const int desiredValue = 1;

        public override string ID()
        {
            return "Disable PowerThrottling";
        }

        public override string Info()
        {
            return "With the Windows 10 Fall Creators Update, Microsoft’s OS has added feature called Power Throttling\n" +
                   "(Power Throttling is only available on Intel 6th gen and higher processors), a way to increase the battery life of laptops by slowing down background processes.\n" +
                   "This feature is enabled by default in laptops and tablets. Though Windows is good at detecting background apps and limiting power, there might be situations where this feature is not so desirable.";
        }

        public override bool CheckAssessment()
        {
            return !(
               RegistryHelper.IntEquals(keyName, "PowerThrottlingOff", desiredValue)
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "PowerThrottlingOff", desiredValue, RegistryValueKind.DWord);

                logger.Log("- PowerThrottling has been successfully enabled.");
                logger.Log(keyName);
                return true;
            }
            catch
            { }

            return false;
        }

        public override bool UndoAssessment()
        {
            try
            {
                var RegKey = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Power\PowerThrottling", true);
                RegKey.DeleteValue("PowerThrottlingOff");

                logger.Log("- PowerThrottling has been successfully enabled.");
                logger.Log(keyName);
                return true;
            }
            catch
            { }

            return false;
        }
    }
}