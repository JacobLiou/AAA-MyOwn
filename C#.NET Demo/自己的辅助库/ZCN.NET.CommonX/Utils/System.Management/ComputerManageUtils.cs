using System;
using System.Management;

namespace ZCN.NET.CommonX.Utils
{
    /// <summary>
    ///  计算机硬件信息管理工具类
    /// </summary>
    public class ComputerManageUtils
    {
        #region 属性

        public static readonly string UnKnowInfo = "未知";

        /// <summary>
        ///  获取系统标识符和版本号
        /// </summary>
        public static string OsVersion
        {
            get { return Environment.OSVersion.ToString(); }
        }

        /// <summary>
        ///  获取映射到进程上下文的物理内存量
        /// </summary>
        public static string WorkingSet
        {
            get { return Environment.WorkingSet.ToString(); }
        }

        /// <summary>
        ///  获取系统启动后经过的毫秒数
        /// </summary>
        public static int TickCount
        {
            get { return Environment.TickCount; }
        }

        /// <summary>
        ///  获取系统目录的完全限定路径
        /// </summary>
        public static string SystemDirectory
        {
            get { return Environment.SystemDirectory; }
        }

        /// <summary>
        ///  获取此本地计算机的 NetBIOS 名称
        /// </summary>
        public static string MachineName
        {
            get { return Environment.MachineName; }
        }

        /// <summary>
        ///  获取与当前用户关联的网络域名
        /// </summary>
        public static string UserDomainName
        {
            get { return Environment.UserDomainName; }
        }

        /// <summary>
        ///  获取电脑名称
        /// </summary>
        /// <returns></returns>
        public static string GetComputerName()
        {
            try
            {
                return Environment.GetEnvironmentVariable("ComputerName");
            }
            catch
            {
                return UnKnowInfo;
            }
        }

        #endregion

        #region 方法

        /// <summary>
        ///  获取 Cpu 序列号。
        ///  通过 Win32_Processor 获取 CPUID 不正确，或者说 Win32_Processor 字段就不包含 CPU 编号信息
        /// </summary>
        /// <returns></returns>
        public static string GetCpuSerialNumber()
        {
            try
            {
                string cpuInfo = ""; //cpu序列号

                ManagementClass mc = new ManagementClass("Win32_Processor");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
                }

                return cpuInfo;
            }
            catch
            {
                return UnKnowInfo;
            }
        }

        /// <summary>
        ///  获取主板序列号。
        ///  通过Win32_BaseBoard获取主板信息，但不是所有的主板都有编号，或者说不是能获取所有系统主板的编号。
        /// </summary>
        /// <returns></returns>
        public static string GetBaseBoardSerialNumber()
        {
            try
            {
                string motherBoardInfo = ""; //主板序列号
                ManagementClass mc = new ManagementClass("Win32_BaseBoard");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    motherBoardInfo = mo.Properties["SerialNumber"].Value.ToString();
                }

                return motherBoardInfo;
            }
            catch
            {
                return UnKnowInfo;
            }
        }

        /// <summary>
        ///  获取 BIOS 序列号。
        ///  通过 Win32_BIOS 获取 BIOS 信息，基本和获取主板信息差不多。就是说：不是所有的主板 BIOS 信息都有编号
        /// </summary>
        /// <returns></returns>
        public static string GetBiosSerialNumber()
        {
            try
            {
                string motherBoardInfo = ""; //BIOS序列号
                ManagementClass mc = new ManagementClass("Win32_BIOS");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    motherBoardInfo = mo.Properties["SerialNumber"].Value.ToString();
                }

                return motherBoardInfo;
            }
            catch
            {
                return UnKnowInfo;
            }
        }

        /// <summary>
        ///  获取网卡硬件地址
        /// </summary>
        /// <returns></returns>
        public static string GetMacAddress()
        {
            try
            {
                //获取网卡硬件地址
                string mac = "";
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    if ((bool)mo["IPEnabled"] == true)
                    {
                        mac = mo["MacAddress"].ToString();
                        break;
                    }
                }

                return mac;
            }
            catch
            {
                return UnKnowInfo;
            }
        }

        /// <summary>
        ///  获取IP地址
        /// </summary>
        /// <returns></returns>
        public static string GetIpAddress()
        {
            try
            {
                //获取IP地址
                string st = "";
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    if ((bool)mo["IPEnabled"])
                    {
                        Array arr = (Array)(mo.Properties["IpAddress"].Value);
                        st = arr.GetValue(0).ToString();
                        break;
                    }
                }

                return st;
            }
            catch
            {
                return UnKnowInfo;
            }
        }

        /// <summary>
        ///   获取硬盘ID
        /// </summary>
        /// <returns></returns>
        public static string GetDiskId()
        {
            try
            {
                //获取硬盘ID
                string diskId = "";
                ManagementClass mc = new ManagementClass("Win32_DiskDrive");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    diskId = (string)mo.Properties["SerialNumber"].Value; //SerialNumber
                    if (diskId != null)
                    {
                        return diskId;
                    }
                }

                return diskId;
            }
            catch
            {
                return UnKnowInfo;
            }
        }

        /// <summary>
        ///   获取硬盘序列号。
        ///   网上有提到，用 Win32_DiskDrive，但是用 Win32_DiskDrive 获得的硬盘信息中并不包含 SerialNumber 属性
        /// </summary>
        /// <returns></returns>
        public static string GetDiskSerialNumber()
        {
            try
            {
                //获取硬盘ID
                string diskId = "";
                ManagementClass mc = new ManagementClass("Win32_PhysicalMedia");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    diskId = (string)mo.Properties["SerialNumber"].Value;
                }

                return diskId;
            }
            catch
            {
                return UnKnowInfo;
            }
        }

        /// <summary>
        ///  操作系统的登录用户名
        /// </summary>
        /// <returns></returns>
        public static string GetUserName()
        {
            try
            {
                string st = "";
                ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    st = mo["UserName"].ToString();
                }

                return st;
            }
            catch
            {
                return UnKnowInfo;
            }
        }

        /// <summary>
        ///  获取计算机操作系统类型
        /// </summary>
        /// <returns></returns>
        public static string GetSystemType()
        {
            try
            {
                string st = "";
                ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    st = mo["SystemType"].ToString();
                }

                return st;
            }
            catch
            {
                return UnKnowInfo;
            }
        }

        /// <summary>
        ///  获取电脑物理内存
        /// </summary>
        /// <returns></returns>
        public static string GetTotalPhysicalMemory()
        {
            try
            {
                string st = "";
                ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc)
                {
                    st = mo["TotalPhysicalMemory"].ToString();
                }

                return st;
            }
            catch
            {
                return UnKnowInfo;
            }
        }

        #endregion
    }
}