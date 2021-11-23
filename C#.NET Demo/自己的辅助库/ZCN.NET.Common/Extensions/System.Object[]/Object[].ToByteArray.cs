namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将指定对象数组转换为字节数组
        /// </summary>
        /// <param name="tempObjectArray">要确定其类型的对象数组</param>
        public static byte[] ToByteArray(this object[] tempObjectArray)
        {
            if (tempObjectArray == null || tempObjectArray.Length == 0)
                return null;

            byte[] byteArray = new byte[tempObjectArray.Length];
            for (int index = 0; index < tempObjectArray.Length; index++)
            {
                byteArray[index] = (byte)tempObjectArray[index];
            }

            return byteArray;
        }
    }
}