﻿using Microsoft.Win32;

namespace ThisIsWin11.PumpedApp.Assessment.Apps
{
    internal class FileSystem : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\CapabilityAccessManager\ConsentStore\broadFileSystemAccess";
        private const string desiredValue = "Deny";

        public override string ID()
        {
            return "App access to file system";
        }

        public override string Info()
        {
            return "";
        }

        public override bool CheckAssessment()
        {
            return !(
               RegistryHelper.StringEquals(keyName, "Value", desiredValue)
             );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "Value", desiredValue, RegistryValueKind.String);

                logger.Log("- App access to filesystem has been successfully disabled.");
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
                Registry.SetValue(keyName, "Value", "Allow", RegistryValueKind.String);
                logger.Log("- App access to filesystem has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}