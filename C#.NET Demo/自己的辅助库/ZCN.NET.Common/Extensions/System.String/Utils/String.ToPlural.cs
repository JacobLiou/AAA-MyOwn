//using System.Data.Entity.Design.PluralizationServices;
//using System.Globalization;

//namespace ZCN.NET.Common.Extensions
//{
//    public static partial class CommonExtensions
//    {
//        /// <summary>
//        ///   �Զ�����չ����������ָ�����ʵĸ�����ʽ
//        /// </summary>
//        /// <param name="this">��չ����</param>
//        /// <returns>���ʵĸ�����ʽ</returns>
//        public static string ToPlural(this string @this)
//        {
//            return PluralizationService.CreateService(new CultureInfo("en-US")).Pluralize(@this);
//        }

//        /// <summary>
//        ///   �Զ�����չ����������ָ�����ʵĸ�����ʽ
//        /// </summary>
//        /// <param name="this">��չ����</param>
//        /// <param name="cultureInfo">������Ϣ����</param>
//        /// <returns>���ʵĸ�����ʽ</returns>
//        public static string ToPlural(this string @this, CultureInfo cultureInfo)
//        {
//            return PluralizationService.CreateService(cultureInfo).Pluralize(@this);
//        }
//    }
//}