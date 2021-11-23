using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

using ZCN.NET.CommonX.Extensions;

namespace ZCN.NET.CommonX.Utils
{
    /// <summary>
    ///     RSA操作类
    /// </summary>
    public class RSAHelper
    {
        private RSACryptoServiceProvider _rsa;

        /// <summary>
        ///  使用指定的密钥大小初始化 <see cref="T:System.Security.Cryptography.RSACryptoServiceProvider" /> 类的新实例。
        /// <para>如果需要转换已知的XML或PEM格式的秘钥，请使用RSAHelper(string xmlOrPem, RSAKeyType keyType)重载方法</para>
        /// </summary>
        /// <param name="keySize">要使用的密钥的大小（以位为单位）。默认为1024。如果手动设置建议使用：512、1024、2048、4096</param>
        public RSAHelper(int keySize = 1024)
        {
            Init();

            var rsaParams = new CspParameters { Flags = CspProviderFlags.UseMachineKeyStore };
            _rsa = new RSACryptoServiceProvider(keySize, rsaParams);
        }

        /// <summary>
        ///  通过 XML 字符串中的密钥(公钥或者私钥)信息初始化 <see cref="T:System.Security.Cryptography.RSA" /> 对象。
        /// </summary>
        /// <param name="xmlOrPem"> XML 字符串或者 PEM 格式字符串，其中包含公钥或者私钥</param>
        /// <param name="keyType">RSA 密钥格式</param>
        public RSAHelper(string xmlOrPem, RSAKeyType keyType)
        {
            Init();

            if (keyType == RSAKeyType.XML)
            {
                _rsa.FromXmlString(xmlOrPem);
            }
            else if (keyType == RSAKeyType.PEM)
            {
                _rsa = RSA_PEM_Utility.FromPEM(xmlOrPem);
            }
        }

        /// <summary>
        ///     导出XML格式密钥对，如果convertToPublic含私钥的RSA将只返回公钥，仅含公钥的RSA不受影响
        /// </summary>
        /// <param name="convertToPublic">是否导出为公钥。false时导出私钥</param>
        public string ToXML(bool convertToPublic = false)
        {
            return _rsa.ToXmlString(!_rsa.PublicOnly && !convertToPublic);
        }

        /// <summary>
        ///     导出PEM PKCS#1格式密钥对，如果convertToPublic含私钥的RSA将只返回公钥，仅含公钥的RSA不受影响
        /// </summary>
        /// <param name="convertToPublic">是否导出为公钥。false时导出私钥</param>
        public string ToPEM_PKCS1(bool convertToPublic = false)
        {
            return RSA_PEM_Utility.ToPEM(_rsa, convertToPublic, false);
        }

        /// <summary>
        ///     导出PEM PKCS#8格式密钥对，如果convertToPublic含私钥的RSA将只返回公钥，仅含公钥的RSA不受影响
        /// </summary>
        public string ToPEM_PKCS8(bool convertToPublic = false)
        {
            return RSA_PEM_Utility.ToPEM(_rsa, convertToPublic, true);
        }

        /// <summary>
        ///     加密字符串（utf-8），出错抛异常
        /// </summary>
        public string Encode(string str)
        {
            return Encode(Encoding.UTF8.GetBytes(str)).ToBase64String();
        }

        /// <summary>
        ///     加密数据，出错抛异常
        /// </summary>
        public byte[] Encode(byte[] data)
        {
            int blockLen = _rsa.KeySize / 8 - 11;
            if (data.Length <= blockLen)
            {
                return _rsa.Encrypt(data, false);
            }

            using (var dataStream = new MemoryStream(data))
            using (var enStream = new MemoryStream())
            {
                byte[] buffer = new byte[blockLen];
                int len = dataStream.Read(buffer, 0, blockLen);

                while (len > 0)
                {
                    byte[] block = new byte[len];
                    Array.Copy(buffer, 0, block, 0, len);

                    byte[] enBlock = _rsa.Encrypt(block, false);
                    enStream.Write(enBlock, 0, enBlock.Length);

                    len = dataStream.Read(buffer, 0, blockLen);
                }

                return enStream.ToArray();
            }
        }

        /// <summary>
        ///     解密字符串（utf-8），解密异常返回null
        /// </summary>
        public string DecodeOrNull(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            byte[] bytes = str.ToByteArrayByBase64();
            if (bytes == null)
            {
                return null;
            }

            byte[] val = DecodeOrNull(bytes);
            if (val == null)
            {
                return null;
            }

            return Encoding.UTF8.GetString(val);
        }

        /// <summary>
        ///     解密数据，解密异常返回null
        /// </summary>
        public byte[] DecodeOrNull(byte[] data)
        {
            try
            {
                int blockLen = _rsa.KeySize / 8;
                if (data.Length <= blockLen)
                {
                    return _rsa.Decrypt(data, false);
                }

                using (var dataStream = new MemoryStream(data))
                using (var deStream = new MemoryStream())
                {
                    byte[] buffer = new byte[blockLen];
                    int len = dataStream.Read(buffer, 0, blockLen);

                    while (len > 0)
                    {
                        byte[] block = new byte[len];
                        Array.Copy(buffer, 0, block, 0, len);

                        byte[] deBlock = _rsa.Decrypt(block, false);
                        deStream.Write(deBlock, 0, deBlock.Length);

                        len = dataStream.Read(buffer, 0, blockLen);
                    }

                    return deStream.ToArray();
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///     对str进行签名，并指定hash算法（如：SHA256）
        /// </summary>
        public string SignData(string hash, string str)
        {
            return SignData(hash, Encoding.UTF8.GetBytes(str)).ToBase64String();
        }

        /// <summary>
        ///     对data进行签名，并指定hash算法（如：SHA256）
        /// </summary>
        public byte[] SignData(string hash, byte[] data)
        {
            return _rsa.SignData(data, hash);
        }

        /// <summary>
        ///     验证字符串str的签名是否是sign，并指定hash算法（如：SHA256）
        /// </summary>
        public bool VerifyData(string hash, string sign, string str)
        {
            byte[] bytes = sign.ToByteArrayByBase64();
            if (bytes == null)
            {
                return false;
            }

            return VerifyData(hash, bytes, Encoding.UTF8.GetBytes(str));
        }

        /// <summary>
        ///     验证data的签名是否是sign，并指定hash算法（如：SHA256）
        /// </summary>
        public bool VerifyData(string hash, byte[] sign, byte[] data)
        {
            try
            {
                return _rsa.VerifyData(data, hash, sign);
            }
            catch
            {
                return false;
            }
        }

        private void Init()
        {
            var cspParams = new CspParameters
            {
                Flags = CspProviderFlags.UseMachineKeyStore
            };
            _rsa = new RSACryptoServiceProvider(cspParams);
        }
    }
}