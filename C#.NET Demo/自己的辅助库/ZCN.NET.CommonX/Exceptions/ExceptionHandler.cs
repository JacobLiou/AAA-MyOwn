using System;
using System.Collections.Generic;

namespace ZCN.NET.CommonX.Exceptions
{
    /// <summary>
    ///     自定义异常信息处理程序
    /// </summary>
    public class ExceptionHandler
    {
        #region 公共方法

        #region 暂时注释

        ///// <summary>
        /////     检验参数合法性，数值类型不能小于0，引用类型不能为null，否则抛出相应异常
        ///// </summary>
        ///// <param name="arg">待检参数</param>
        ///// <param name="argName">待检参数名称</param>
        ///// <param name="canBeZero">数值类型是否可以等于0</param>
        ///// <exception cref="ComponentException" />
        //public static void CheckArgument(object arg, string argName, bool canBeZero = false)
        //{
        //    if (arg == null)
        //    {
        //        ArgumentNullException ex = new ArgumentNullException(argName);

        //        throw ThrowComponentException(string.Format("参数 【{0}】 为 Null，引发空异常。", argName), ex);
        //    }

        //    Type type = arg.GetType();

        //    //type.IsValueType && type.IsType()
        //    if (type.IsValueType)
        //    {
        //        bool flag = !canBeZero ? Convert.ToDouble(arg) <= 0.0 : Convert.ToDouble(arg) < 0.0;
        //        if (flag)
        //        {
        //            ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException(argName);

        //            throw ThrowComponentException(string.Format("参数 【{0}】 不在有效范围内引发异常。具体信息请查看系统日志。", argName), ex);
        //        }
        //    }

        //    if (type == typeof(Guid) && (Guid)arg == Guid.Empty)
        //    {
        //        ArgumentNullException ex = new ArgumentNullException(argName);

        //        throw ThrowComponentException(string.Format("参数 【{0}】为空Guid引发异常。", argName), ex);
        //    }
        //}


        /// <summary>
        ///     检验参数合法性，数值类型不能小于0，引用类型不能为null，否则抛出相应异常
        /// </summary>
        /// <param name="args">待检数组参数</param>
        /// <param name="argName">待检参数名称</param>
        /// <param name="canBeEmpty">集合为空是是否抛出异常</param>
        /// <exception cref="ComponentException" />
        public static void CheckArgument(object[] args, string argName, bool canBeEmpty = false)
        {
            if (args == null)
            {
                ArgumentNullException ex = new ArgumentNullException(argName);

                throw ThrowComponentException(string.Format("参数 【{0}】 为 Null，引发空异常。", argName), ex);
            }

            if (args.Length == 0)
            {
                ArgumentNullException ex = new ArgumentNullException(argName);

                throw ThrowComponentException(string.Format("参数 【{0}】 数组长度为0，引发空异常。", argName), ex);
            }
        }

        /// <summary>
        ///     检验参数合法性，引用类型不能为null，否则抛出相应异常
        /// </summary>
        /// <param name="arrArgs">待检数组参数</param>
        /// <param name="argName">待检参数名称</param>
        /// <param name="canBeEmpty">集合为空是是否抛出异常</param>
        /// <exception cref="ComponentException" />
        public static void CheckArgument<T>(List<T> arrArgs, string argName, bool canBeEmpty = false)
        {
            if (arrArgs == null)
            {
                ArgumentNullException ex = new ArgumentNullException(argName);

                throw ThrowComponentException(string.Format("参数 【{0}】 为 Null，引发空异常。", argName), ex);
            }

            if (canBeEmpty == false && arrArgs.Count == 0)
            {
                ArgumentNullException ex = new ArgumentNullException(argName);

                throw ThrowComponentException(string.Format("参数 【{0}】 集合长度为0，引发空异常。", argName), ex);
            }
        }

        #endregion

        /// <summary>
        ///     向调用层抛出业务逻辑异常
        /// </summary>
        /// <param name="msg">自定义异常消息</param>
        /// <param name="ex">实际引发异常的异常实例</param>
        public static BusinessException ThrowBusinessException(string msg, System.Exception ex = null)
        {
            if (string.IsNullOrWhiteSpace(msg) && ex != null)
            {
                msg = ex.Message;
            }
            else if (string.IsNullOrWhiteSpace(msg))
            {
                msg = "未知业务逻辑异常，详情请查看日志信息。";
            }

            return ex == null
                       ? new BusinessException(string.Format("[{0}", msg))
                       : new BusinessException(string.Format("[{0}]", msg), ex);
        }

        /// <summary>
        ///     向调用层抛出组件异常
        /// </summary>
        /// <param name="msg">自定义异常消息</param>
        /// <param name="ex">实际引发异常的异常实例</param>
        public static ComponentException ThrowComponentException(string msg, System.Exception ex = null)
        {
            if (string.IsNullOrWhiteSpace(msg) && ex != null)
            {
                msg = ex.Message;
            }
            else if (string.IsNullOrWhiteSpace(msg))
            {
                msg = "未知组件异常，详情请查看日志信息。";
            }

            return ex == null
                       ? new ComponentException(string.Format("[{0}]", msg))
                       : new ComponentException(string.Format("[{0}]", msg), ex);
        }

        /// <summary>
        ///     向调用层抛出缓存异常
        /// </summary>
        /// <param name="msg">自定义异常消息</param>
        /// <param name="ex">实际引发异常的异常实例</param>
        public static CacheException ThrowCacheException(string msg, System.Exception ex = null)
        {
            if (string.IsNullOrWhiteSpace(msg) && ex != null)
            {
                msg = ex.Message;
            }
            else if (string.IsNullOrWhiteSpace(msg))
            {
                msg = "未知组件异常，详情请查看日志信息。";
            }

            return ex == null
                       ? new CacheException(string.Format("[{0}]", msg))
                       : new CacheException(string.Format("[{0}]", msg), ex);
        }

        /// <summary>
        ///     向调用层抛出数据访问组件异常
        /// </summary>
        /// <param name="msg">自定义异常消息</param>
        /// <param name="ex">实际引发异常的异常实例</param>
        public static DataAccessException ThrowDataAccessException(string msg, System.Exception ex = null)
        {
            if (string.IsNullOrWhiteSpace(msg) && ex != null)
            {
                msg = ex.Message;
            }
            else if (string.IsNullOrWhiteSpace(msg))
            {
                msg = "未知数据访问层异常，详情请查看日志信息。";
            }

            return ex == null
                       ? new DataAccessException(string.Format("[{0}]", msg))
                       : new DataAccessException(string.Format("[{0}]", msg), ex);
        }

        /// <summary>
        ///     由错误码返回指定的自定义SqlException异常信息
        /// </summary>
        /// <param name="exceptionCode">错误码</param>
        /// <returns> </returns>
        public static string GetSqlExceptionMessage(int exceptionCode)
        {
            string msg = string.Empty;
            switch (exceptionCode)
            {
                case 2:
                    msg = "连接数据库超时，请检查网络连接或者数据库服务器是否正常。";
                    break;

                case 17:
                    msg = "SqlServer服务不存在或拒绝访问。";
                    break;

                case 208:
                    msg = "指定名称的表不存在。";
                    break;

                case 547:
                    msg = "外键约束，无法保存数据的变更。";
                    break;

                case 2601:
                    msg = "未知错误。";
                    break;

                case 2627:
                    msg = "主键重复，无法插入数据。";
                    break;

                case 2812:
                    msg = "指定存储过程不存在。";
                    break;

                case 4060: //数据库无效。
                    msg = "所连接的数据库无效。";
                    break;

                case 17142:
                    msg = "SqlServer服务已暂停，不能提供数据服务。";
                    break;

                case 18456: //登录失败
                    msg = "使用设定的用户名与密码登录数据库失败。";
                    break;
            }

            return msg;
        }

        #endregion
    }
}