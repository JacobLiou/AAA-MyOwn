using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������Ӳ�ҵ�������취��������� true ���� false
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static bool CoinToss(this Random @this)
        {
            return @this.Next(2) == 0;
        }
    }
}