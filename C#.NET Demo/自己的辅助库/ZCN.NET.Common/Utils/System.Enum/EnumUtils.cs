using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

using ZCN.NET.Common.Extensions;

namespace ZCN.NET.Common.Utils
{
    /// <summary>
    ///     枚举操作工具类
    /// </summary>
    public class EnumUtils
    {
        /// <summary>
        ///    将一个或多个枚举常数的名称或数字值的字符串表示转换成等效的枚举对象。
        /// 当此方法返回时，如果分析操作成功，结果将包含值由 <paramref name="member" /> 表示的 TEnum 类型的对象。 如果分析操作失败，结果将包含 TEnum 的基础类型的默认值。 请注意，此值无需为 TEnum 枚举的成员。
        /// </summary>
        /// <typeparam name="TEnum">要将 <paramref name="member" /> 转换到的枚举类型。</typeparam>
        /// <param name="member">
        ///     枚举成员的常量名或常量值,
        ///     范例:Enum1枚举有两个成员A=0,B=1,则传入"A"或"0"获取 Enum1.A 枚举类型
        /// </param>
        /// <param name="ignoreCase">是否忽略大小写</param>
        public static TEnum GetInstance<TEnum>(string member, bool ignoreCase = false) where TEnum : struct
        {
            Enum.TryParse<TEnum>(member, ignoreCase, out TEnum result);
            return result;
        }

        /// <summary>
        ///     获取枚举成员名称和成员值的键值对集合
        /// </summary>
        /// <typeparam name="TEnum">枚举名,比如Enum1</typeparam>
        public static Dictionary<string, object> GetMemberKeyValue<TEnum>() where TEnum : struct
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();

            //获取枚举所有成员名称
            string[] memberNames = GetMemberNames<TEnum>();

            //遍历枚举成员
            foreach (string memberName in memberNames)
            {
                dic.Add(memberName, GetMemberValue<TEnum>(memberName));
            }

            //返回哈希表
            return dic;
        }

        /// <summary>
        ///     获取枚举所有成员名称
        /// </summary>
        /// <typeparam name="TEnum">枚举名,比如Enum1</typeparam>
        public static string[] GetMemberNames<TEnum>()
        {
            return Enum.GetNames(typeof(TEnum));
        }

        /// <summary>
        ///     获取枚举成员的名称
        /// </summary>
        /// <typeparam name="TEnum">枚举名,比如Enum1</typeparam>
        /// <param name="member">
        ///     枚举成员实例或成员值,
        ///     范例:Enum1枚举有两个成员A=0,B=1,则传入Enum1.A或0,获取成员名称"A"
        /// </param>
        public static string GetMemberName<TEnum>(object member)
        {
            //转成基础类型的成员值
            Type underlyingType = GetUnderlyingType(typeof(TEnum));
            object memberValue = member.ConvertTo(underlyingType);//  ConvertHelper.ConvertTo(member, underlyingType);

            //获取枚举成员的名称
            return Enum.GetName(typeof(TEnum), memberValue);
        }

        /// <summary>
        ///     获取枚举所有成员值
        /// </summary>
        /// <typeparam name="TEnum">枚举名,比如Enum1</typeparam>
        public static Array GetMemberValues<TEnum>()
        {
            return Enum.GetValues(typeof(TEnum));
        }

        /// <summary>
        ///     获取枚举成员的值
        /// </summary>
        /// <typeparam name="TEnum">枚举名,比如Enum1</typeparam>
        /// <param name="memberName">
        ///     枚举成员的常量名,
        ///     范例:Enum1枚举有两个成员A=0,B=1,则传入"A"获取0
        /// </param>
        public static object GetMemberValue<TEnum>(string memberName) where TEnum : struct
        {
            //获取基础类型
            Type underlyingType = GetUnderlyingType(typeof(TEnum));

            //获取枚举实例
            TEnum instance = GetInstance<TEnum>(memberName);

            //获取枚举成员的值
            return instance.ConvertTo(underlyingType); //ConvertHelper.ConvertTo(instance, underlyingType);
        }

        /// <summary>
        ///     获取枚举的基础类型
        /// </summary>
        /// <param name="enumType">枚举类型</param>
        public static Type GetUnderlyingType(Type enumType)
        {
            //获取基础类型
            return Enum.GetUnderlyingType(enumType);
        }

        /// <summary>
        ///     检测枚举是否包含指定成员
        /// </summary>
        /// <typeparam name="TEnum">枚举名,比如Enum1</typeparam>
        /// <param name="member">枚举成员名或成员值</param>
        public static bool IsDefined<TEnum>(string member)
        {
            return Enum.IsDefined(typeof(TEnum), member);
        }

        /// <summary>
        ///     返回指定枚举类型的指定值的描述
        /// </summary>
        /// <param name="t">枚举类型</param>
        /// <param name="v">枚举值</param>
        /// <returns></returns>
        public static string GetDescription(Type t, object v)
        {
            try
            {
                FieldInfo fi = t.GetField(GetName(t, v));
                DescriptionAttribute[] attributes =
                    (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

                return attributes.Length > 0 ? attributes[0].Description : GetName(t, v);
            }
            catch
            {
                return "UNKNOWN";
            }
        }

        /// <summary>
        ///     返回指定枚举类型的指定值的名称
        /// </summary>
        /// <param name="t">指定枚举类型</param>
        /// <param name="v">指定值</param>
        /// <returns></returns>
        private static string GetName(Type t, object v)
        {
            try
            {
                return Enum.GetName(t, v);
            }
            catch
            {
                return "UNKNOWN";
            }
        }

        /// <summary>
        ///     获取枚举类型的对应序号及描述名称
        /// </summary>
        /// <param name="t">枚举类型</param>
        /// <returns></returns>
        public static SortedList GetStatus(Type t)
        {
            SortedList list = new SortedList();

            Array a = Enum.GetValues(t);
            for (int i = 0; i < a.Length; i++)
            {
                string enumName = a.GetValue(i).ToString();
                int enumKey = (int)Enum.Parse(t, enumName);
                string enumDescription = GetDescription(t, enumKey);
                list.Add(enumKey, enumDescription);
            }

            return list;
        }
    }
}