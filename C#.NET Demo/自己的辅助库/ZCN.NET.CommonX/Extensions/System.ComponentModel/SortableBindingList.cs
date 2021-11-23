using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    /// <summary>
    ///     自定义类，继承BindingList(默认BindingList不支持排序),
    ///     使集合支持排序功能，提供支持数据绑定的泛型集合
    /// </summary>
    public class SortableBindingList<T> : BindingList<T>
    {
        /// <summary>
        ///     空构造函数
        /// </summary>
        public SortableBindingList()
        {
        }

        /// <summary>
        ///     构造函数
        /// </summary>
        /// <param name="list"></param>
        public SortableBindingList(IList<T> list)
            : base(list)
        {
        }

        #region 属性

        private bool _isSortedCore = true;
        private ListSortDirection _sortDirectionCore = ListSortDirection.Ascending;
        private PropertyDescriptor _sortPropertyCore;
        private string _defaultSortItem;

        /// <summary>
        ///     获取或设置默认排序项
        /// </summary>
        public string DefaultSortItem
        {
            get => _defaultSortItem;
            set
            {
                if (_defaultSortItem != value)
                {
                    _defaultSortItem = value;
                    Sort();
                }
            }
        }

        #endregion

        #region 重载方法

        protected override bool SupportsSortingCore => true;

        protected override bool SupportsSearchingCore => true;

        protected override bool IsSortedCore => _isSortedCore;

        protected override ListSortDirection SortDirectionCore => _sortDirectionCore;

        protected override PropertyDescriptor SortPropertyCore => _sortPropertyCore;

        protected override int FindCore(PropertyDescriptor prop, object key)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Equals(prop.GetValue(this[i]), key)) return i;
            }

            return -1;
        }

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            _isSortedCore = true;
            _sortPropertyCore = prop;
            _sortDirectionCore = direction;
            Sort();
        }

        protected override void RemoveSortCore()
        {
            if (_isSortedCore)
            {
                _isSortedCore = false;
                _sortPropertyCore = null;
                _sortDirectionCore = ListSortDirection.Ascending;
                Sort();
            }
        }

        #endregion

        #region 辅助方法

        /// <summary>
        ///     排序
        /// </summary>
        private void Sort()
        {
            List<T> list = Items as List<T>;
            list.Sort(CompareCore);
            ResetBindings();
        }

        /// <summary>
        ///     比较2个泛型对象
        /// </summary>
        /// <param name="o1">泛型对象1</param>
        /// <param name="o2">泛型对象2</param>
        /// <returns></returns>
        private int CompareCore(T o1, T o2)
        {
            int ret = 0;
            if (SortPropertyCore != null)
            {
                ret = CompareValue(SortPropertyCore.GetValue(o1), SortPropertyCore.GetValue(o2),
                                   SortPropertyCore.PropertyType);
            }

            if (ret == 0 && DefaultSortItem != null)
            {
                PropertyInfo property = typeof(T).GetProperty(DefaultSortItem,
                                                              BindingFlags.Public
                                                            | BindingFlags.GetProperty
                                                            | BindingFlags.Instance
                                                            | BindingFlags.IgnoreCase, null, null, new Type[0], null);
                if (property != null)
                {
                    ret = CompareValue(property.GetValue(o1, null), property.GetValue(o2, null), property.PropertyType);
                }
            }

            if (SortDirectionCore == ListSortDirection.Descending) ret = -ret;

            return ret;
        }

        /// <summary>
        ///     对比2个值
        /// </summary>
        /// <param name="o1">值1</param>
        /// <param name="o2">值2</param>
        /// <param name="type">类型</param>
        /// <returns></returns>
        private static int CompareValue(object o1, object o2, Type type)
        {
            if (o1 == null) return o2 == null ? 0 : -1;

            if (o2 == null) return 1;

            if (type.IsPrimitive || type.IsEnum) return Convert.ToDouble(o1).CompareTo(Convert.ToDouble(o2));
            if (type == typeof(DateTime)) return Convert.ToDateTime(o1).CompareTo(o2);

            return string.Compare(o1.ToString().Trim(), o2.ToString().Trim());
        }

        #endregion
    }
}