using System;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

using ZCN.NET.Common.Extensions;

namespace ZCN.NET.Common.Utils
{
    /// <summary>
    ///  RSA PEM格式秘钥对的解析和导出
    /// </summary>
    public class RSA_PEM_Utility
    {
        static private readonly Regex PEMCode = new Regex(@"--+.+?--+|\s+");
        static private readonly byte[] SeqOid = new byte[] { 0x30, 0x0D, 0x06, 0x09, 0x2A, 0x86, 0x48, 0x86, 0xF7, 0x0D, 0x01, 0x01, 0x01, 0x05, 0x00 };
        static private readonly byte[] Ver = new byte[] { 0x02, 0x01, 0x00 };

        /// <summary>
        ///  PEM 公钥开头中包含的 PUBLIC KEY
        /// </summary>
        private const string PUBLIC_KEY = "PUBLIC KEY";

        /// <summary>
        ///  PEM 私钥开头中包含的 PRIVATE KEY
        /// </summary>
        private const string PRIVATE_KEY = "PRIVATE KEY";

        private const string PEM_PUBLIC_KEY_BEGIN = "-----BEGIN PUBLIC KEY-----";
        private const string PEM_PUBLIC_KEY_END   = "-----END PUBLIC KEY-----";
        private const string PEM_PRIVATE_KEY_BEGIN = "-----BEGIN PRIVATE KEY-----";
        private const string PEM_PRIVATE_KEY_END = "-----END PRIVATE KEY-----";

        /// <summary>
        ///  用PEM格式密钥对创建RSA对象，支持PKCS#1、PKCS#8格式的PEM
        /// </summary>
        /// <param name="pem">pem格式密钥</param>
        /// <returns></returns>
        public static RSACryptoServiceProvider FromPEM(string pem)
        {
            var rsaParams = new CspParameters();
            rsaParams.Flags = CspProviderFlags.UseMachineKeyStore;
            var rsa = new RSACryptoServiceProvider(rsaParams);

            var param = new RSAParameters();

            var base64Str = PEMCode.Replace(pem, "");
            var data = base64Str.ToByteArrayByBase64();
            if (data == null)
            {
                throw new Exception("PEM内容无效");
            }
            var idx = 0;

            //读取长度
            Func<byte, int> readLen = (first) =>
            {
                if (data[idx] == first)
                {
                    idx++;
                    if (data[idx] == 0x81)
                    {
                        idx++;
                        return data[idx++];
                    }
                    else if (data[idx] == 0x82)
                    {
                        idx++;
                        return (((int)data[idx++]) << 8) + data[idx++];
                    }
                    else if (data[idx] < 0x80)
                    {
                        return data[idx++];
                    }
                }
                throw new Exception("PEM未能提取到数据");
            };

            //读取块数据
            Func<byte[]> readBlock = () =>
            {
                var len = readLen(0x02);
                if (data[idx] == 0x00)
                {
                    idx++;
                    len--;
                }
                var val = data.Sub(idx, len);
                idx += len;
                return val;
            };

            //比较data从idx位置开始是否是bytes内容
            Func<byte[], bool> eq = (bytes) =>
            {
                for (var i = 0; i < bytes.Length; i++, idx++)
                {
                    if (idx >= data.Length)
                    {
                        return false;
                    }
                    if (bytes[i] != data[idx])
                    {
                        return false;
                    }
                }
                return true;
            };

            if (pem.Contains(PUBLIC_KEY))
            {
                /****使用公钥****/
                //读取数据总长度
                readLen(0x30);
                if (!eq(SeqOid))
                {
                    throw new Exception("PEM未知格式");
                }
                //读取1长度
                readLen(0x03);
                idx++;//跳过0x00
                      //读取2长度
                readLen(0x30);

                //Modulus
                param.Modulus = readBlock();

                //Exponent
                param.Exponent = readBlock();
            }
            else if (pem.Contains(PRIVATE_KEY))
            {
                /****使用私钥****/
                //读取数据总长度
                readLen(0x30);

                //读取版本号
                if (!eq(Ver))
                {
                    throw new Exception("PEM未知版本");
                }

                //检测PKCS8
                var idx2 = idx;
                if (eq(SeqOid))
                {
                    //读取1长度
                    readLen(0x04);
                    //读取2长度
                    readLen(0x30);

                    //读取版本号
                    if (!eq(Ver))
                    {
                        throw new Exception("PEM版本无效");
                    }
                }
                else
                {
                    idx = idx2;
                }

                //读取数据
                param.Modulus = readBlock();
                param.Exponent = readBlock();
                param.D = readBlock();
                param.P = readBlock();
                param.Q = readBlock();
                param.DP = readBlock();
                param.DQ = readBlock();
                param.InverseQ = readBlock();
            }
            else
            {
                throw new Exception("pem需要BEGIN END标头");
            }

            rsa.ImportParameters(param);
            return rsa;
        }

        /// <summary>
        /// 将RSA中的密钥对转换成PEM格式，usePKCS8=false时返回PKCS#1格式，否则返回PKCS#8格式。
        /// 如果convertToPublic含私钥的RSA将只返回公钥，仅含公钥的RSA不受影响
        /// </summary>
        /// <param name="rsa">RSA加密对象</param>
        /// <param name="convertToPublic">是否导出为公钥。false时导出私钥</param>
        /// <param name="usePKCS8">是否返回PKCS8格式</param>
        /// <returns></returns>
        public static string ToPEM(RSACryptoServiceProvider rsa, bool convertToPublic, bool usePKCS8)
        {
            //https://www.jianshu.com/p/25803dd9527d
            //https://www.cnblogs.com/ylz8401/p/8443819.html
            //https://blog.csdn.net/jiayanhui2877/article/details/47187077
            //https://blog.csdn.net/xuanshao_/article/details/51679824
            //https://blog.csdn.net/xuanshao_/article/details/51672547

            var ms = new MemoryStream();
            //写入一个长度字节码
            Action<int> writeLenByte = (len) =>
            {
                if (len < 0x80)
                {
                    ms.WriteByte((byte)len);
                }
                else if (len <= 0xff)
                {
                    ms.WriteByte(0x81);
                    ms.WriteByte((byte)len);
                }
                else
                {
                    ms.WriteByte(0x82);
                    ms.WriteByte((byte)(len >> 8 & 0xff));
                    ms.WriteByte((byte)(len & 0xff));
                }
            };

            //写入一块数据
            Action<byte[]> writeBlock = (bytes) =>
            {
                var addZero = (bytes[0] >> 4) >= 0x8;
                ms.WriteByte(0x02);
                var len = bytes.Length + (addZero ? 1 : 0);
                writeLenByte(len);

                if (addZero)
                {
                    ms.WriteByte(0x00);
                }
                ms.Write(bytes, 0, bytes.Length);
            };

            //根据后续内容长度写入长度数据
            Func<int, byte[], byte[]> writeLen = (index, bytes) =>
            {
                var len = bytes.Length - index;

                ms.SetLength(0);
                ms.Write(bytes, 0, index);
                writeLenByte(len);
                ms.Write(bytes, index, len);

                return ms.ToArray();
            };

            if (rsa.PublicOnly || convertToPublic)
            {
                /****生成公钥****/
                var param = rsa.ExportParameters(false);


                //写入总字节数，不含本段长度，额外需要24字节的头，后续计算好填入
                ms.WriteByte(0x30);
                var index1 = (int)ms.Length;

                //固定内容
                // encoded OID sequence for PKCS #1 rsaEncryption szOID_RSA_RSA = "1.2.840.113549.1.1.1"
                ms.WriteByteArray(SeqOid);

                //从0x00开始的后续长度
                ms.WriteByte(0x03);
                var index2 = (int)ms.Length;
                ms.WriteByte(0x00);

                //后续内容长度
                ms.WriteByte(0x30);
                var index3 = (int)ms.Length;

                //写入Modulus
                writeBlock(param.Modulus);

                //写入Exponent
                writeBlock(param.Exponent);


                //计算空缺的长度
                var bytes = ms.ToArray();

                bytes = writeLen(index3, bytes);
                bytes = writeLen(index2, bytes);
                bytes = writeLen(index1, bytes);

                return PEM_PUBLIC_KEY_BEGIN + "\n" + bytes.ToBase64String().BreakText(64) + "\n" + PEM_PUBLIC_KEY_END;
            }
            else
            {
                /****生成私钥****/
                var param = rsa.ExportParameters(true);

                //写入总字节数，后续写入
                ms.WriteByte(0x30);
                int index1 = (int)ms.Length;

                //写入版本号
                ms.WriteByteArray(Ver);

                //PKCS8 多一段数据
                int index2 = -1, index3 = -1;
                if (usePKCS8)
                {
                    //固定内容
                    ms.WriteByteArray(SeqOid);

                    //后续内容长度
                    ms.WriteByte(0x04);
                    index2 = (int)ms.Length;

                    //后续内容长度
                    ms.WriteByte(0x30);
                    index3 = (int)ms.Length;

                    //写入版本号
                    ms.WriteByteArray(Ver);
                }

                //写入数据
                writeBlock(param.Modulus);
                writeBlock(param.Exponent);
                writeBlock(param.D);
                writeBlock(param.P);
                writeBlock(param.Q);
                writeBlock(param.DP);
                writeBlock(param.DQ);
                writeBlock(param.InverseQ);


                //计算空缺的长度
                var bytes = ms.ToArray();

                if (index2 != -1)
                {
                    bytes = writeLen(index3, bytes);
                    bytes = writeLen(index2, bytes);
                }
                bytes = writeLen(index1, bytes);

                var flag = " PRIVATE KEY";
                if (!usePKCS8)
                {
                    flag = " RSA" + flag;
                }
                return "-----BEGIN" + flag + "-----\n" + bytes.ToBase64String().BreakText(64) + "\n-----END" + flag + "-----";
            }
        }
    }
}