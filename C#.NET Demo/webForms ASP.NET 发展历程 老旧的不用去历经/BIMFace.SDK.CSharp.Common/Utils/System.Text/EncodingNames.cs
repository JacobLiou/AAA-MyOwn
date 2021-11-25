// /* ---------------------------------------------------------------------------------------
//    文件名：Base64Utility.cs
//    文件功能描述：
// 
//    创建标识：20200308
//    作   者：张传宁 （QQ：905442693  微信：savionzhang）  
//    作者博客：https://www.cnblogs.com/SavionZhang/
//    BIMFace专栏地址：https://www.cnblogs.com/SavionZhang/p/11424431.html
// 
//    修改标识： 
//    修改描述：
//  ------------------------------------------------------------------------------------------*/

namespace BIMFace.SDK.CSharp.Common.Utils

{
    /// <summary>
    ///  编码方式常量类
    /// </summary>
    public class EncodingNames
    {
        /// <summary>
        ///  IBM EBCDIC(美国-加拿大)。代码页标识符号：37
        /// </summary>
        public const string IBM037 = "IBM037";

        /// <summary>
        ///  OEM 美国。代码页标识符号：437
        /// </summary>
        public const string IBM437 = "IBM437";

        /// <summary>
        ///  IBM EBCDIC (国际)。代码页标识符号：500       
        /// </summary>
        public const string IBM500 = "IBM500";

        /// <summary>
        ///  阿拉伯字符(ASMO-708)。代码页标识符号：708 
        /// </summary>
        public const string ASMO_708 = "ASMO-708";

        /// <summary>
        ///  阿拉伯字符(DOS)。代码页标识符号：720       
        /// </summary>
        public const string DOS_720 = "DOS-720";

        /// <summary>
        ///  希腊字符(DOS)。代码页标识符号：737       
        /// </summary>
        public const string IBM737 = "ibm737";

        /// <summary>
        ///  波罗的海字符(DOS)。代码页标识符号：775       
        /// </summary>
        public const string IBM775 = "ibm775";

        /// <summary>
        ///  西欧字符(DOS)。代码页标识符号：850       
        /// </summary>
        public const string IBM850 = "ibm850";

        /// <summary>
        ///  中欧字符(DOS)。代码页标识符号：852       
        /// </summary>
        public const string IBM852 = "ibm852";

        /// <summary>
        ///  OEM 西里尔语。代码页标识符号：855       
        /// </summary>
        public const string IBM855 = "IBM855";

        /// <summary>
        ///  土耳其字符(DOS)。代码页标识符号：857       
        /// </summary> 
        public const string IBM857 = "ibm857";

        /// <summary>
        ///  OEM 多语言拉丁语 I。代码页标识符号：858       
        /// </summary>
        public const string IBM00858 = "IBM00858";

        /// <summary>
        ///  葡萄牙语(DOS)。代码页标识符号：860       
        /// </summary>
        public const string IBM860 = "IBM860";

        /// <summary>
        ///  冰岛语(DOS)。代码页标识符号：861       
        /// </summary>
        public const string IBM861 = "ibm861";

        /// <summary>
        ///  希伯来字符(DOS)。代码页标识符号：862      
        /// </summary>
        public const string DOS_862 = "DOS-862";

        /// <summary>
        ///  加拿大法语(DOS)。代码页标识符号：863       
        /// </summary>
        public const string IBM863 = "IBM863";

        /// <summary>
        ///  阿拉伯字符(864)。代码页标识符号：864       
        /// </summary>
        public const string IBM864 = "IBM864";

        /// <summary>
        ///  北欧字符(DOS)。代码页标识符号：865       
        /// </summary>
        public const string IBM865 = "IBM865";

        /// <summary>
        ///  西里尔字符(DOS)。代码页标识符号：866       
        /// </summary>
        public const string CP866 = "cp866";

        /// <summary>
        ///  现代希腊字符(DOS)。代码页标识符号：869       
        /// </summary>
        public const string IBM869 = "ibm869";

        /// <summary>
        ///  IBM EBCDIC(多语言拉丁语 2)。代码页标识符号：870       
        /// </summary>
        public const string IBM870 = "IBM870";

        /// <summary>
        ///  泰语(Windows)。代码页标识符号：874  windows-874     
        /// </summary>
        public const string WINDOWS_874 = "windows-874";

        /// <summary>
        ///  IBM EBCDIC (现代希腊语)。代码页标识符号：875      
        /// </summary>
        public const string CP875 = "cp875";

        /// <summary>
        ///  日语(Shift-JIS)。代码页标识符号：932       
        /// </summary>
        public const string SHIFT_JIS = "shift_jis";

        /// <summary>
        ///  简体中文(GB2312)。代码页标识符号：936      
        /// </summary>
        public const string GB2312 = "GB2312";

        /// <summary>
        ///  朝鲜语。代码页标识符号：949   
        /// </summary>
        public const string KS_C_5601_1987 = "ks_c_5601-1987";

        /// <summary>
        ///  繁体中文(Big5)。代码页标识符号：950       
        /// </summary>
        public const string BIG5 = "big5";

        /// <summary>
        ///  IBM EBCDIC (土耳其拉丁语 5)。代码页标识符号：1026       
        /// </summary>
        public const string IBM1026 = "IBM1026";

        /// <summary>
        ///  IBM 拉丁语 1。代码页标识符号：1047       
        /// </summary>
        public const string IBM01047 = "IBM01047";

        /// <summary> 
        ///  IBM EBCDIC (美国-加拿大-欧洲)。代码页标识符号：1140       
        /// </summary>
        public const string IBM01140 = "IBM01140";

        /// <summary>
        ///  IBM EBCDIC (德国-欧洲)。代码页标识符号：1141       
        /// </summary>
        public const string IBM01141 = "IBM01141";

        /// <summary>
        ///  IBM EBCDIC (丹麦-挪威-欧洲)。代码页标识符号：1142       
        /// </summary>
        public const string IBM01142 = "IBM01142";

        /// <summary>
        ///  IBM EBCDIC (芬兰-瑞典-欧洲)。代码页标识符号：1143       
        /// </summary>
        public const string IBM01143 = "IBM01143";

        /// <summary>
        ///  IBM EBCDIC (意大利-欧洲)。代码页标识符号：1144       
        /// </summary>
        public const string IBM01144 = "IBM01144";

        /// <summary>
        ///  IBM EBCDIC (西班牙-欧洲)。代码页标识符号：1145      
        /// </summary>
        public const string IBM01145 = "IBM01145";

        /// <summary>
        ///  IBM EBCDIC (英国-欧洲)。代码页标识符号：1146       
        /// </summary>
        public const string IBM01146 = "IBM01146";

        /// <summary>
        ///  IBM EBCDIC (法国-欧洲)。代码页标识符号：1147       
        /// </summary>
        public const string IBM01147 = "IBM01147";

        /// <summary>
        ///  IBM EBCDIC (国际-欧洲)。代码页标识符号：1148       
        /// </summary>
        public const string IBM01148 = "IBM01148";

        /// <summary>
        ///  IBM EBCDIC (冰岛语-欧洲)。代码页标识符号：1149       
        /// </summary>
        public const string IBM01149 = "IBM01149";

        /// <summary>
        ///  Unicode。代码页标识符号：1200      
        /// </summary>
        public const string UTF_16 = "utf-16";

        /// <summary>
        ///  Unicode (Big-Endian)。代码页标识符号：201       
        /// </summary>
        public const string UTF_16_BE = "utf-16BE";

        /// <summary>
        ///  中欧字符(Windows)。代码页标识符号：1250  windows-1250     
        /// </summary>
        public const string WINDOWS_1250 = "windows-1250";

        /// <summary>
        ///  西里尔字符(Windows)。代码页标识符号：1251  windows-1251     
        /// </summary>
        public const string WINDOWS_1251 = "windows-1251";

        /// <summary>
        ///   西欧字符(Windows)。代码页标识符号：1252      
        /// </summary>
        public const string WINDOWS_1252 = "Windows-1252";

        /// <summary>
        ///  希腊字符(Windows)。代码页标识符号：1253       
        /// </summary>
        public const string WINDOWS_1253 = "windows-1253";

        /// <summary>
        ///  土耳其字符(Windows)。代码页标识符号：1254       
        /// </summary>
        public const string WINDOWS_1254 = "windows-1254";

        /// <summary>
        ///  希伯来字符(Windows)。代码页标识符号：1255       
        /// </summary>
        public const string WINDOWS_1255 = "windows-1255";

        /// <summary>
        ///  阿拉伯字符(Windows)。代码页标识符号：1256       
        /// </summary>
        public const string WINDOWS_1256 = "windows-1256";

        /// <summary>
        ///  波罗的海字符(Windows)。代码页标识符号：1257       
        /// </summary>
        public const string WINDOWS_1257 = "windows-1257";

        /// <summary>
        ///  越南字符(Windows)。代码页标识符号：1258      
        /// </summary>
        public const string WINDOWS_1258 = "windows-1258";

        /// <summary>
        ///  朝鲜语(Johab)。代码页标识符号：1361      
        /// </summary>
        public const string JOHAB = "Johab";

        /// <summary>
        ///  西欧字符(Mac)。代码页标识符号：10000       
        /// </summary>
        public const string MACINTOSH = "macintosh";

        /// <summary>
        ///  日语(Mac)。代码页标识符号：10001       
        /// </summary>
        public const string X_MAC_JAPANESE = "x-mac-japanese";

        /// <summary>
        ///  繁体中文(Mac)。代码页标识符号：10002    
        /// </summary>
        public const string X_MAC_CHINESETRAD = "x-mac-chinesetrad";

        /// <summary>
        ///  朝鲜语(Mac)。代码页标识符号：10003       
        /// </summary>
        public const string X_MAC_KOREAN = "x-mac-korean";

        /// <summary>
        ///  阿拉伯字符(Mac)。代码页标识符号：10004       
        /// </summary>
        public const string X_MAC_ARABIC = "x-mac-arabic";

        /// <summary>
        ///  希伯来字符(Mac)。代码页标识符号：10005       
        /// </summary>
        public const string X_MAC_HEBREW = "x-mac-hebrew";

        /// <summary>
        ///  希腊字符(Mac)。代码页标识符号：10006       
        /// </summary>
        public const string X_MAC_GREEK = "x-mac-greek";

        /// <summary>
        ///  西里尔字符(Mac)。代码页标识符号：10007       
        /// </summary>
        public const string X_MAC_CYRILLIC = "x-mac-cyrillic";

        /// <summary>
        ///  简体中文(Mac)。代码页标识符号：10008       
        /// </summary>
        public const string X_MAC_CHINESESIMP = "x-mac-chinesesimp";

        /// <summary>
        ///  罗马尼亚语(Mac)。代码页标识符号：10010       
        /// </summary>
        public const string X_MAC_ROMANIAN = "x-mac-romanian";

        /// <summary>
        ///  乌克兰语(Mac)。代码页标识符号：10017       
        /// </summary>
        public const string X_MAC_UKRAINIAN = "x-mac-ukrainian";

        /// <summary>
        ///  泰语(Mac)。代码页标识符号：10021      
        /// </summary>
        public const string X_MAC_THAI = "x-mac-thai";

        /// <summary>
        ///  中欧字符(Mac)。代码页标识符号：10029      
        /// </summary>
        public const string X_MAC_CE = "x-mac-ce";

        /// <summary>
        ///  冰岛语(Mac)。代码页标识符号：10079       
        /// </summary>
        public const string X_MAC_ICELANDIC = "x-mac-icelandic";

        /// <summary>
        ///  土耳其字符(Mac)。代码页标识符号：10081  x-mac-turkish     
        /// </summary>
        public const string X_MAC_TURKISH = "x-mac-turkish";

        /// <summary>
        ///  克罗地亚语(Mac)。代码页标识符号：10082       
        /// </summary>
        public const string X_MAC_CROATIAN = "x-mac-croatian";

        /// <summary>
        ///  Unicode (UTF-32)。代码页标识符号：12000       
        /// </summary>
        public const string UTF_32 = "utf-32";

        /// <summary>
        ///  Unicode (UTF-32 Big-Endian)。代码页标识符号：12001  utf-32BE     
        /// </summary>
        public const string UTF_32_BE = "utf-32BE";

        /// <summary>
        ///  繁体中文(CNS)。代码页标识符号：20000       
        /// </summary>
        public const string X_CHINESE_CNS = "x-Chinese-CNS";

        /// <summary>
        ///  TCA 台湾。代码页标识符号：20001       
        /// </summary>
        public const string X_CP20001 = "x-cp20001";

        /// <summary>
        ///  繁体中文(Eten)。代码页标识符号：20002       
        /// </summary>
        public const string X_CHINESE_ETEN = "x-Chinese-Eten";

        /// <summary>
        ///  IBM5550 台湾。代码页标识符号：20003       
        /// </summary>
        public const string X_CP20003 = "x-cp20003";

        /// <summary>
        ///  TeleText 台湾。代码页标识符号：20004       
        /// </summary>
        public const string X_CP20004 = "x-cp20004";

        /// <summary>
        ///  Wang 台湾。代码页标识符号：20005       
        /// </summary>
        public const string X_CP20005 = "x-cp20005";

        /// <summary>
        ///  西欧字符(IA5)。代码页标识符号：20105       
        /// </summary>
        public const string X_IA5 = "x-IA5";

        /// <summary>
        ///  德语(IA5)。代码页标识符号：20106       
        /// </summary>
        public const string X_IA5_GERMAN = "x-IA5-German";

        /// <summary>
        ///  瑞典语(IA5)。代码页标识符号：20107       
        /// </summary>
        public const string X_IA5_SWEDISH = "x-IA5-Swedish";

        /// <summary>
        ///  挪威语(IA5)。代码页标识符号：20108      
        /// </summary>
        public const string X_IA5_NORWEGIAN = "x-IA5-Norwegian";

        /// <summary>
        ///  US-ASCII。代码页标识符号：20127       
        /// </summary>
        public const string US_ASCII = "us-ascii";

        /// <summary>
        ///  T.61。代码页标识符号：20261  x-cp20261     
        /// </summary>
        public const string X_CP20261 = "x-cp20261";

        /// <summary>
        ///  ISO-6937。代码页标识符号：20269       
        /// </summary>
        public const string X_CP20269 = "x-cp20269";

        /// <summary>
        ///  IBM EBCDIC (德国)。代码页标识符号：20273       
        /// </summary>
        public const string IBM273 = "IBM273";

        /// <summary>
        ///  IBM EBCDIC (丹麦-挪威)。代码页标识符号：20277       
        /// </summary>
        public const string IBM277 = "IBM277";

        /// <summary>
        ///  IBM EBCDIC (芬兰-瑞典)。代码页标识符号：20278       
        /// </summary>
        public const string IBM278 = "IBM278";

        /// <summary>
        ///  IBM EBCDIC (意大利)。代码页标识符号：20280       
        /// </summary>
        public const string IBM280 = "IBM280";

        /// <summary>
        ///  IBM EBCDIC (西班牙)。代码页标识符号：20284       
        /// </summary>
        public const string IBM284 = "IBM284";

        /// <summary>
        ///  IBM EBCDIC (UK)。代码页标识符号：20285       
        /// </summary>
        public const string IBM285 = "IBM285";

        /// <summary>
        ///  IBM EBCDIC (日语片假名)。代码页标识符号：20290       
        /// </summary>
        public const string IBM290 = "IBM290";

        /// <summary>
        ///  IBM EBCDIC (法国)。代码页标识符号：20297       
        /// </summary>
        public const string IBM297 = "IBM297";

        /// <summary>
        ///  IBM EBCDIC (阿拉伯语)。代码页标识符号：20420       
        /// </summary>
        public const string IBM420 = "IBM420";

        /// <summary>
        ///  IBM EBCDIC (希腊语)。代码页标识符号：20423       
        /// </summary>
        public const string IBM423 = "IBM423";

        /// <summary>
        ///  IBM EBCDIC (希伯来语)。代码页标识符号：20424       
        /// </summary>
        public const string IBM424 = "IBM424";

        /// <summary>
        ///  IBM EBCDIC (朝鲜语扩展)。代码页标识符号：20833       
        /// </summary>
        public const string X_EBCDIC_KOREAN_EXTENDED = "x-EBCDIC-KoreanExtended";

        /// <summary>
        ///  IBM EBCDIC (泰语)。代码页标识符号：20838      
        /// </summary>
        public const string IBM_THAI = "IBM-Thai";

        /// <summary>
        ///  西里尔字符(KOI8-R)。代码页标识符号：20866       
        /// </summary>
        public const string KOI8_R = "koi8-r";

        /// <summary>
        ///  IBM EBCDIC (冰岛语)。代码页标识符号：20871       
        /// </summary>
        public const string IBM871 = "IBM871";

        /// <summary>
        ///  IBM EBCDIC (西里尔俄语)。代码页标识符号：20880       
        /// </summary>
        public const string IBM880 = "IBM880";

        /// <summary>
        ///  IBM EBCDIC (土耳其语)。代码页标识符号：20905       
        /// </summary>
        public const string IBM905 = "IBM905";

        /// <summary>
        ///  IBM 拉丁语 1。代码页标识符号：20924       
        /// </summary>
        public const string IBM00924 = "IBM00924";

        /// <summary>
        ///  v。代码页标识符号：20932  
        /// </summary>
        public const string EUC_JP = "EUC-JP";

        /// <summary>
        ///  简体中文(GB2312-80)。代码页标识符号：20936       
        /// </summary>
        public const string X_CP20936 = "x-cp20936";

        /// <summary>
        ///  朝鲜语 Wansung。代码页标识符号：20949      
        /// </summary>
        public const string X_CP20949 = "x-cp20949";

        /// <summary>
        ///  IBM EBCDIC (西里尔塞尔维亚-保加利亚语)。代码页标识符号：21025     
        /// </summary>
        public const string CP1025 = "cp1025";

        /// <summary>
        ///  西里尔字符(KOI8-U)。代码页标识符号：21866       
        /// </summary>
        public const string KOI8_U = "koi8-u";

        /// <summary>
        ///  西欧字符(ISO)。代码页标识符号：28591       
        /// </summary>
        public const string ISO_8859_1 = "iso-8859-1";

        /// <summary>
        ///  中欧字符(ISO)。代码页标识符号：28592       
        /// </summary>
        public const string ISO_8859_2 = "iso-8859-2";

        /// <summary>
        ///  拉丁语 3 (ISO)。代码页标识符号：28593
        /// </summary>
        public const string ISO_8859_3 = "iso-8859-3";

        /// <summary>
        ///  波罗的海字符(ISO)。代码页标识符号：28594       
        /// </summary>
        public const string ISO_8859_4 = "iso-8859-4";

        /// <summary>
        ///  西里尔字符(ISO)。代码页标识符号：28595       
        /// </summary>
        public const string ISO_8859_5 = "iso-8859-5";

        /// <summary>
        ///  阿拉伯字符(ISO)。代码页标识符号：28596      
        /// </summary>
        public const string ISO_8859_6 = "iso-8859-6";

        /// <summary>
        ///  希腊字符(ISO)。代码页标识符号：28597       
        /// </summary>
        public const string ISO_8859_7 = "iso-8859-7";

        /// <summary>
        ///  希伯来字符(ISO-Visual)。代码页标识符号：28598       
        /// </summary>
        public const string ISO_8859_8 = "iso-8859-8";

        /// <summary>
        ///  土耳其字符(ISO)。代码页标识符号：28599      
        /// </summary>
        public const string ISO_8859_9 = "iso-8859-9";

        /// <summary>
        ///  爱沙尼亚语(ISO)。代码页标识符号：28603       
        /// </summary>
        public const string ISO_8859_13 = "iso-8859-13";

        /// <summary>
        ///  拉丁语 9 (ISO)。代码页标识符号：28605       
        /// </summary>
        public const string ISO_8859_15 = "iso-8859-15";

        /// <summary>
        ///  欧罗巴。代码页标识符号：29001       
        /// </summary>
        public const string X_EUROPA = "x-Europa";

        /// <summary>
        ///  希伯来字符(ISO-Logical)。代码页标识符号：38598       
        /// </summary>
        public const string ISO_8859_8_I = "iso-8859-8-i";

        /// <summary>
        ///  日语(JIS)。代码页标识符号：50220       
        /// </summary>
        public const string ISO_2022_JP = "iso-2022-jp";

        /// <summary>
        ///  日语(JIS-允许 1 字节假名)。代码页标识符号：50221       
        /// </summary>
        public const string CS_ISO2022_JP = "csISO2022JP";

        ///// <summary>
        /////  日语(JIS-允许 1 字节假名 - SO/SI)。代码页标识符号：50222       
        ///// </summary>
        //public const string iso_2022_jp = "iso-2022-jp";

        /// <summary>
        ///  朝鲜语(ISO)。代码页标识符号：50225       
        /// </summary>
        public const string ISO_2022_KR = "iso-2022-kr";

        /// <summary>
        ///  简体中文(ISO-2022)。代码页标识符号：50227       
        /// </summary>
        public const string X_CP50227 = "x-cp50227";

        /// <summary>
        ///  日语(EUC)。代码页标识符号：51932     
        /// </summary>
        public const string euc_jp = "euc-jp";

        /// <summary>
        ///  简体中文(EUC)。代码页标识符号：51936      
        /// </summary>
        public const string EUC_CN = "EUC-CN";

        /// <summary>
        ///  朝鲜语(EUC)。代码页标识符号：51949      
        /// </summary>
        public const string EUC_KR = "euc-kr";

        /// <summary>
        ///  简体中文(HZ)。代码页标识符号：52936       
        /// </summary>
        public const string HZ_GB_2312 = "hz-gb-2312";

        /// <summary>
        ///  简体中文(GB18030)。代码页标识符号：54936       
        /// </summary>
        public const string GB18030 = "GB18030";

        /// <summary>
        ///  ISCII 梵文。代码页标识符号：57002       
        /// </summary>
        public const string X_ISCII_DE = "x-iscii-de";

        /// <summary>
        ///  ISCII 孟加拉语。代码页标识符号：57003       
        /// </summary>
        public const string X_ISCII_BE = "x-iscii-be";

        /// <summary>
        ///  ISCII 泰米尔语。代码页标识符号：57004       
        /// </summary>
        public const string X_ISCII_TA = "x-iscii-ta";

        /// <summary>
        ///  ISCII 泰卢固语。代码页标识符号：57005       
        /// </summary>
        public const string X_ISCII_TE = "x-iscii-te";

        /// <summary>
        ///  ISCII 阿萨姆语。代码页标识符号：57006       
        /// </summary>
        public const string X_ISCII_AS = "x-iscii-as";

        /// <summary>
        ///  ISCII 奥里雅语。代码页标识符号：57007       
        /// </summary>
        public const string X_ISCII_OR = "x-iscii-or";

        /// <summary>
        ///  ISCII 卡纳达语。代码页标识符号：57008       
        /// </summary>
        public const string X_ISCII_KA = "x-iscii-ka";

        /// <summary>
        ///  ISCII 马拉雅拉姆语。代码页标识符号：57009       
        /// </summary>
        public const string X_ISCII_MA = "x-iscii-ma";

        /// <summary>
        ///  ISCII 古吉拉特语。代码页标识符号：57010       
        /// </summary>
        public const string X_ISCII_GU = "x-iscii-gu";

        /// <summary>
        ///  ISCII 旁遮普语。代码页标识符号：57011       
        /// </summary>
        public const string X_ISCII_PA = "x-iscii-pa";

        /// <summary>
        ///  Unicode (UTF-7)。代码页标识符号：65000       
        /// </summary>
        public const string UTF_7 = "utf-7";

        /// <summary>
        ///  Unicode (UTF-8)。代码页标识符号：65001     
        /// </summary>
        public const string UTF_8 = "utf-8";
    }
}