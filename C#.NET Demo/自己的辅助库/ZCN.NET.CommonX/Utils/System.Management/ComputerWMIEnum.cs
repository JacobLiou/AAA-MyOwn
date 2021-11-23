namespace ZCN.NET.CommonX.Utils
{
    /// <summary>
    ///     计算机硬件名称配置枚举
    /// </summary>
    public enum ComputerWMIEnum
    {
        /// <summary>
        ///     主板
        /// </summary>
        Win32_BaseBoard,

        /// <summary>
        ///     BIOS 芯片
        /// </summary>
        Win32_BIOS,

        /// <summary>
        ///     光盘驱动器
        /// </summary>
        Win32_CDROMDrive,

        /// <summary>
        ///     硬盘驱动器
        /// </summary>
        Win32_DiskDrive,

        /// <summary>
        ///     显示器
        /// </summary>
        Win32_DesktopMonitor,

        /// <summary>
        ///     显卡
        /// </summary>
        Win32_DisplayConfiguration,

        /// <summary>
        ///     显卡设置
        /// </summary>
        Win32_DisplayControllerConfiguration,

        /// <summary>
        ///     软盘驱动器
        /// </summary>
        Win32_FloppyDrive,

        /// <summary>
        ///     键盘
        /// </summary>
        Win32_Keyboard,

        /// <summary>
        ///     网络适配器
        /// </summary>
        Win32_NetworkAdapter,

        /// <summary>
        ///     网络适配器设置
        /// </summary>
        Win32_NetworkAdapterConfiguration,

        /// <summary>
        ///     并口
        /// </summary>
        Win32_ParallelPort,

        /// <summary>
        ///     CPU 处理器
        /// </summary>
        Win32_Processor,

        /// <summary>
        ///     物理内存条
        /// </summary>
        Win32_PhysicalMemory,

        /// <summary>
        /// 物理媒介
        /// </summary>
        Win32_PhysicalMedia,

        /// <summary>
        ///     输入设备，包括鼠标。
        /// </summary>
        Win32_PointingDevice,

        /// <summary>
        ///     打印机
        /// </summary>
        Win32_Printer,

        /// <summary>
        ///     打印机设置
        /// </summary>
        Win32_PrinterConfiguration,

        /// <summary>
        ///     打印机任务
        /// </summary>
        Win32_PrintJob,

        /// <summary>
        ///     Moden
        /// </summary>
        Win32_POTSModem,

        /// <summary>
        ///     Moden端口
        /// </summary>
        Win32_POTSModemToSerialPort,

        /// <summary>
        ///     串口
        /// </summary>
        Win32_SerialPort,

        /// <summary>
        ///     串口配置
        /// </summary>
        Win32_SerialPortConfiguration,

        /// <summary>
        ///     多媒体设置，一般指声卡。
        /// </summary>
        Win32_SoundDevice,

        /// <summary>
        ///     主板插槽 (ISA & PCI & AGP)
        /// </summary>
        Win32_SystemSlot,

        /// <summary>
        ///     打印机端口
        /// </summary>
        Win32_TCPIPPrinterPort,

        /// <summary>
        ///     USB 控制器
        /// </summary>
        Win32_USBController,

        /// <summary>
        ///     显卡细节
        /// </summary>
        Win32_VideoController,

        /// <summary>
        ///     显卡支持的显示模式
        /// </summary>
        Win32_VideoSettings,
    }
}