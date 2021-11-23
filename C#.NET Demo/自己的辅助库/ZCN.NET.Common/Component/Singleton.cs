using System;

namespace ZCN.NET.Common.Component
{
	public static class Singleton<T> where T : new()
	{
		private class Nested
		{
			internal static readonly T Current;
			static Nested()
			{
				Singleton<T>.Nested.Current = ((default(T) == null) ? Activator.CreateInstance<T>() : default(T));
			}
		}

        /// <summary>
        ///  ��ȡ���������ʵ��
        /// </summary>
		public static T Current
		{
			get
			{
				return Singleton<T>.Nested.Current;
			}
		}
	}
}
