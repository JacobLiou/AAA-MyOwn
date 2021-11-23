using System;
using System.Configuration;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime;

using ZCN.NET.CommonX.Extensions;

namespace ZCN.NET.CommonX.Utils
{
    /// <summary>
    ///     自定义类：用户管理项目的“AssemblyInfo.cs”文件
    /// </summary>
    public sealed class AssemblyUtils
    {
        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的AssemblyAlgorithmIdAttribute属性
        /// </summary>
        /// <returns></returns>
        public static AssemblyAlgorithmIdAttribute GetAssemblyAlgorithmIdAttribute()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
            var attr =
                (AssemblyAlgorithmIdAttribute) Attribute.GetCustomAttribute(asm, typeof(AssemblyAlgorithmIdAttribute));

            return attr;
        }

        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的AssemblyCompanyAttribute属性
        /// </summary>
        /// <returns></returns>
        public static AssemblyCompanyAttribute GetAssemblyCompanyAttribute()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
            var attr = (AssemblyCompanyAttribute) Attribute.GetCustomAttribute(asm, typeof(AssemblyCompanyAttribute));

            return attr;
        }

        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的AssemblyCopyrightAttribute属性
        /// </summary>
        /// <returns></returns>
        public static AssemblyCopyrightAttribute GetAssemblyCopyrightAttribute()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
            var attr =
                (AssemblyCopyrightAttribute) Attribute.GetCustomAttribute(asm, typeof(AssemblyCopyrightAttribute));

            return attr;
        }

        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的AssemblyConfigurationAttribute属性
        /// </summary>
        /// <returns></returns>
        public static AssemblyConfigurationAttribute GetAssemblyConfigurationAttribute()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
            var attr =
                (AssemblyConfigurationAttribute)
                Attribute.GetCustomAttribute(asm, typeof(AssemblyConfigurationAttribute));

            return attr;
        }

        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的AssemblyCultureAttribute属性
        /// </summary>
        /// <returns></returns>
        public static AssemblyCultureAttribute GetAssemblyCultureAttribute()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
            var attr = (AssemblyCultureAttribute) Attribute.GetCustomAttribute(asm, typeof(AssemblyCultureAttribute));

            return attr;
        }

        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的AssemblyDefaultAliasAttribute属性
        /// </summary>
        /// <returns></returns>
        public static AssemblyDefaultAliasAttribute GetAssemblyDefaultAliasAttribute()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
            var attr =
                (AssemblyDefaultAliasAttribute)
                Attribute.GetCustomAttribute(asm, typeof(AssemblyDefaultAliasAttribute));

            return attr;
        }

        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的AssemblyDelaySignAttribute属性
        /// </summary>
        /// <returns></returns>
        public static AssemblyDelaySignAttribute GetAssemblyDelaySignAttribute()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
            var attr =
                (AssemblyDelaySignAttribute) Attribute.GetCustomAttribute(asm, typeof(AssemblyDelaySignAttribute));

            return attr;
        }

        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的AssemblyDescriptionAttribute属性
        /// </summary>
        /// <returns></returns>
        public static AssemblyDescriptionAttribute GetAssemblyDescriptionAttribute()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
            var attr =
                (AssemblyDescriptionAttribute) Attribute.GetCustomAttribute(asm, typeof(AssemblyDescriptionAttribute));

            return attr;
        }

        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的AssemblyFlagsAttribute属性
        /// </summary>
        /// <returns></returns>
        public static AssemblyFlagsAttribute GetAssemblyFlagsAttribute()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
            var attr =
                (AssemblyFlagsAttribute) Attribute.GetCustomAttribute(asm, typeof(AssemblyFlagsAttribute));

            return attr;
        }

        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的AssemblyInformationalVersionAttribute属性
        /// </summary>
        /// <returns></returns>
        public static AssemblyInformationalVersionAttribute GetAssemblyInformationalVersionAttribute()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
            var attr =
                (AssemblyInformationalVersionAttribute)
                Attribute.GetCustomAttribute(asm, typeof(AssemblyInformationalVersionAttribute));

            return attr;
        }

        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的AssemblyKeyFileAttribute属性
        /// </summary>
        /// <returns></returns>
        public static AssemblyKeyFileAttribute GetAssemblyKeyFileAttribute()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
            var attr =
                (AssemblyKeyFileAttribute) Attribute.GetCustomAttribute(asm, typeof(AssemblyKeyFileAttribute));

            return attr;
        }

        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的AssemblyKeyNameAttribute属性
        /// </summary>
        /// <returns></returns>
        public static AssemblyKeyNameAttribute GetAssemblyKeyNameAttribute()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
            var attr =
                (AssemblyKeyNameAttribute) Attribute.GetCustomAttribute(asm, typeof(AssemblyKeyNameAttribute));

            return attr;
        }

        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的AssemblyProductAttribute属性
        /// </summary>
        /// <returns></returns>
        public static AssemblyProductAttribute GetAssemblyProductAttribute()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
            var attr =
                (AssemblyProductAttribute) Attribute.GetCustomAttribute(asm, typeof(AssemblyProductAttribute));

            return attr;
        }

        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的AssemblyTitleAttribute属性
        /// </summary>
        /// <returns></returns>
        public static AssemblyTitleAttribute GetAssemblyTitleAttribute()
        {
            Assembly asm = Assembly.GetAssembly(AppDomain.CurrentDomain.GetType()); //如果是当前程序集
            var attr =
                (AssemblyTitleAttribute) Attribute.GetCustomAttribute(asm, typeof(AssemblyTitleAttribute));

            return attr;
        }

        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的AssemblyTrademarkAttribute属性
        /// </summary>
        /// <returns></returns>
        public static AssemblyTrademarkAttribute GetAssemblyTrademarkAttribute()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
            var attr =
                (AssemblyTrademarkAttribute) Attribute.GetCustomAttribute(asm, typeof(AssemblyTrademarkAttribute));

            return attr;
        }

        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的AssemblyVersionAttribute属性
        /// </summary>
        /// <returns></returns>
        public static AssemblyVersionAttribute GetAssemblyVersionAttribute()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
            var attr =
                (AssemblyVersionAttribute) Attribute.GetCustomAttribute(asm, typeof(AssemblyVersionAttribute));

            return attr;
        }

        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的ApplicationScopedSettingAttribute属性
        /// </summary>
        /// <returns></returns>
        public static ApplicationScopedSettingAttribute GetApplicationScopedSettingAttribute()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
            var attr =
                (ApplicationScopedSettingAttribute)
                Attribute.GetCustomAttribute(asm, typeof(ApplicationScopedSettingAttribute));

            return attr;
        }

        /// <summary>
        ///     获取程序集配置文件【AssemblyInfo.cs】中的AssemblyTargetedPatchBandAttribute属性
        /// </summary>
        /// <returns></returns>
        public static AssemblyTargetedPatchBandAttribute GetAssemblyTargetedPatchBandAttribute()
        {
            Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
            var attr =
                (AssemblyTargetedPatchBandAttribute)
                Attribute.GetCustomAttribute(asm, typeof(AssemblyTargetedPatchBandAttribute));

            return attr;
        }

        #region 版本号

        /// <summary>
        ///     获取dll或者exe程序集的版本信息
        /// </summary>
        /// <param name="filePath">dll或者exe程序集的文件全路径</param>
        /// <returns></returns>
        public static Version GetAssemblyVersion(string filePath)
        {
            //通过反射加载dll文件，然后获取其版本信息
            Assembly assembly = Assembly.LoadFile(filePath);
            AssemblyName assemblyName = assembly.GetName();
            Version version = assemblyName.Version;

            return version;
        }

        /// <summary>
        ///     获取dll或者exe程序集的文件版本信息
        /// </summary>
        /// <param name="filePath">dll或者exe程序集的文件全路径</param>
        /// <returns></returns>
        public static FileVersionInfo GetAssemblyFileVersion(string filePath)
        {
            if(filePath.IsNullOrWhiteSpace())
            {
                Assembly asm = Assembly.GetExecutingAssembly(); //如果是当前程序集
                filePath = asm.Location;
            }

            try
            {
                return FileVersionInfo.GetVersionInfo(filePath);
            }
            catch(System.Exception e)
            {
                return null;
            }
        }

        #endregion
    }
}