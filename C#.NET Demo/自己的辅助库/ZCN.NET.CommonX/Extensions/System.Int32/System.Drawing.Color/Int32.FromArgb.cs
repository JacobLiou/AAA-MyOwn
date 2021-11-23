using System;
using System.Drawing;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������һ�� 32 λ ARGB ֵ���� System.Drawing.Color �ṹ
        /// </summary>
        /// <param name="argb">��չ����ָ�� 32 λ ARGB ֵ��ֵ</param>
        /// <returns></returns>
        public static Color FromArgb(this Int32 argb)
        {
            return Color.FromArgb(argb);
        }

        /// <summary>
        /// �Զ�����չ���������ĸ� ARGB ������alpha����ɫ����ɫ����ɫ��ֵ���� System.Drawing.Color �ṹ��
        /// ���ܴ˷�������Ϊÿ���������� 32 λֵ����ÿ��������ֵ������ 8 λ
        /// </summary>
        /// <param name="argb">��չ����alpha ��������ЧֵΪ�� 0 �� 255</param>
        /// <param name="red">��ɫ��������ЧֵΪ�� 0 �� 255</param>
        /// <param name="green">��ɫ��������ЧֵΪ�� 0 �� 255</param>
        /// <param name="blue">��ɫ��������ЧֵΪ�� 0 �� 255</param>
        /// <returns></returns>
        public static Color FromArgb(this Int32 argb, Int32 red, Int32 green, Int32 blue)
        {
            return Color.FromArgb(argb, red, green, blue);
        }

        /// <summary>
        /// �Զ�����չ��������ָ���� 8 λ��ɫֵ����ɫ����ɫ����ɫ������ System.Drawing.Color �ṹ��
        /// alpha ֵĬ��Ϊ 255����ȫ��͸������
        /// ���ܴ˷�������Ϊÿ����ɫ�������� 32 λֵ����ÿ��������ֵ������ 8 λ
        /// </summary>
        /// <param name="argb">��չ���󡣺�ɫ��������ЧֵΪ�� 0 �� 255</param>
        /// <param name="green">��ɫ��������ЧֵΪ�� 0 �� 255</param>
        /// <param name="blue">��ɫ��������ЧֵΪ�� 0 �� 255</param>
        /// <returns></returns>
        public static Color FromArgb(this Int32 argb, Int32 green, Int32 blue)
        {
            return Color.FromArgb(argb, green, blue);
        }

        /// <summary>
        /// �Զ�����չ������ ��ָ���� System.Drawing.Color �ṹ���� System.Drawing.Color �ṹ����Ҫʹ����ָ���� alpha ֵ��
        /// ���ܴ˷�������Ϊalpha ֵ���� 32 λֵ������ֵ������ 8 λ
        /// </summary>
        /// <param name="argb">��չ������ System.Drawing.Color �� alpha ֵ����ЧֵΪ�� 0 �� 255</param>
        /// <param name="baseColor">���д����� System.Drawing.Color �� System.Drawing.Color</param>
        /// <returns></returns>
        public static Color FromArgb(this Int32 argb,Color baseColor)
        {
            return Color.FromArgb(argb,baseColor);
        }
    }
}