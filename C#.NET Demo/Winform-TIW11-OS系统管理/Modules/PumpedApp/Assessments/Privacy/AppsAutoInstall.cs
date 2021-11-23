﻿using Microsoft.Win32;
using System;

namespace ThisIsWin11.PumpedApp.Assessment.Privacy
{
    internal class AppsAutoInstall : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ContentDeliveryManager";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "Automatic Installation of apps";
        }

        public override string Info()
        {
            return "When you sign-in to a new Windows 11 profile or device for the first time, chance is that you notice several third - party applications and games listed prominently in the Start menu.\n" +
                    "This setting will block automatic Installation of suggested Windows 11 apps.";
        }

        public override bool CheckAssessment()
        {
            return !(
        RegistryHelper.IntEquals(keyName, "SilentInstalledAppsEnabled", desiredValue)
            );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "SilentInstalledAppsEnabled", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Automatic Installation of apps has been successfully disabled.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable automatic Installation of apps {0}", ex.Message); }

            return false;
        }

        public override bool UndoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "SilentInstalledAppsEnabled", 1, RegistryValueKind.DWord);
                logger.Log("- Automatic Installation of apps has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}