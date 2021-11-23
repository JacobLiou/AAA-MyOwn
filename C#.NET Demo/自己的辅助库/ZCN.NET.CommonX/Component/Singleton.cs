using System;

namespace ZCN.NET.Common.Component
{
	/// <summary>
	/// 泛型类型的单例模式
	/// </summary>
	/// <typeparam name="T"></typeparam>
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

		public static T Current
		{
			get
			{
				return Singleton<T>.Nested.Current;
			}
		}
	}
}
