﻿using Microsoft.Win32;
using System;

namespace ThisIsWin11.PumpedApp.Assessment.Privacy
{
    internal class TailoredExperiences : AssessmentBase
    {
        private static readonly ErrorHelper logger = ErrorHelper.Instance;

        private const string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Privacy";
        private const int desiredValue = 0;

        public override string ID()
        {
            return "Tailored experiences";
        }

        public override string Info()
        {
            return "This will prevent Windows 11 using your diagnostic data for personalized tips, ads, and recommendations.";
        }

        public override bool CheckAssessment()
        {
            return !(
                 RegistryHelper.IntEquals(keyName, "TailoredExperiencesWithDiagnosticDataEnabled", desiredValue)
            );
        }

        public override bool DoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "TailoredExperiencesWithDiagnosticDataEnabled", desiredValue, RegistryValueKind.DWord);

                logger.Log("- Tailored experiences has been successfully disabled.");
                logger.Log(keyName);
                return true;
            }
            catch (Exception ex)
            { logger.Log("Could not disable Tailored experiences {0}", ex.Message); }

            return false;
        }

        public override bool UndoAssessment()
        {
            try
            {
                Registry.SetValue(keyName, "TailoredExperiencesWithDiagnosticDataEnabled", 1, RegistryValueKind.DWord);
                logger.Log("- Tailored experiences has been successfully enabled.");
                return true;
            }
            catch
            { }

            return false;
        }
    }
}