﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace LMS.Core
{

    /// <summary>
    /// 整个站点的Cookie
    /// </summary>
    public static class Cookies
    {
        private static string _cookieKey = string.Empty;

        private static string CookieKey
        {
            get
            {
                if (string.IsNullOrEmpty(_cookieKey))
                {
                    try
                    {
                        _cookieKey = ConfigurationManager.AppSettings["CookieKey"];
                        if (string.IsNullOrEmpty(_cookieKey))
                        {
                            _cookieKey = "SYSTEM";
                        }
                    }
                    catch
                    {
                        _cookieKey = "SYSTEM";
                    }

                }
                return _cookieKey;
            }
        }

        /// <summary>
        /// 错误登陆次数.
        /// </summary>
        public static string LoginErrorCount = string.Format("PCM_{0}_LoginErrorCount", CookieKey);

    }

    /// <summary>
    /// Webconfig配置
    /// </summary>
    public class sysConfig
    {
        /// <summary>
        /// 主站点域名
        /// </summary>
        public static string SiteDomain = ConfigurationManager.AppSettings["Site_Domain"];

        /// <summary>
        /// 公司类型
        /// </summary>
        public static string CompanyType = ConfigurationManager.AppSettings["CompanyType"];


        private static int GetShippingMethodId()
        {
            string specialShippingMethodId = ConfigurationManager.AppSettings["SpecialShippingMethodId"];
            int id = 0;
            bool bResult = int.TryParse(specialShippingMethodId, out id);
            return id;
        }

        /// <summary>
        /// 俄速通小包专线挂号ID
        /// </summary>
        public static int SpecialShippingMethodId = GetShippingMethodId();

        /// <summary>
        /// 中美专线Code
        /// </summary>
        public static string SinoUSShippingMethodCode = GetSinoUSShippingMethodCode();

        /// <summary>
        /// 欧洲专线DDP挂号运输方式Code
        /// </summary>
        public static string DDPRegisterShippingMethodCode = ConfigurationManager.AppSettings["DDPRegisterShippingMethodCode"];

        /// <summary>
        /// 欧洲专线DDP平邮运输方式Code
        /// </summary>
        public static string DDPShippingMethodCode = ConfigurationManager.AppSettings["DDPShippingMethodCode"];
        /// <summary>
        /// 欧洲专线DDP运输方式Id
        /// </summary>
        public static string DDPShippingMethodId = ConfigurationManager.AppSettings["DDPShippingMethodId"];
        /// <summary>
        /// 预报B2C出仓时间起始时间
        /// </summary>
        public static string B2CPreAlterStartTime = ConfigurationManager.AppSettings["B2CPreAlterStartTime"];

        /// <summary>
        /// 欧洲专线运输方式Code
        /// </summary>
        public static string EuropeShippingMethodCode = ConfigurationManager.AppSettings["EuropeShippingMethodCode"];

        /// <summary>
        /// DHL新加坡预报运输方式Code
        /// </summary>
        public static string DHLSingaporeCode = ConfigurationManager.AppSettings["DHL_Singapore_Code"];
        /// <summary>
        /// 立陶宛
        /// </summary>
        public static string LithuaniaShippingMethodCodeId = ConfigurationManager.AppSettings["LithuaniaShippingMethodCodeId"];

        /// <summary>
        /// EUB预报运输方式Code
        /// </summary>
        public static string EUBSingaporeCode = ConfigurationManager.AppSettings["EUB_Singapore_Code"];
        
       
        /// <summary>
        /// DHL新加坡预报服务商Code
        /// </summary>
        public static string DHLVenderCode = ConfigurationManager.AppSettings["DHL_VenderCode"];

        public static string LithuaniaId = ConfigurationManager.AppSettings["LithuaniaId"];

        private static string GetSinoUSShippingMethodCode()
        {
            return ConfigurationManager.AppSettings["SinoUSShippingMethodCode"];
        }
        /// <summary>
        /// 用户中心路径
        /// </summary>
        public static string UserCenterPath = ConfigurationManager.AppSettings["UserCenter_Path"];

        /// <summary>
        /// Eub标签地址下载
        /// </summary>
        public static string LabelDowLoadPath = ConfigurationManager.AppSettings["LabelDowLoadPath"];

        /// <summary>
        /// 图片服务器路径
        /// </summary>
        public static string WebImagePath = ConfigurationManager.AppSettings["WebImagePath"];

		//图片服务器物理路径
		public static string ImagePath = ConfigurationManager.AppSettings["ImagePath"];


        public static string ImageSourcePath = ConfigurationManager.AppSettings["ImageSource_Path"];

        public static string LISAPIPath = ConfigurationManager.AppSettings["LIS_API_Path"];
        /// <summary>
        /// 物流用户中心域路径
        /// </summary>
        public static string LMS_UserCenterDoMain = ConfigurationManager.AppSettings["LMS_UserCenter_DoMain"];
        /// <summary>
        /// LIS域路径
        /// </summary>
        public static string LISDoMain = ConfigurationManager.AppSettings["LIS_DoMain"];

        /// <summary>
        /// 物流系统API路径
        /// </summary>
        public static string LMSAPIPath = ConfigurationManager.AppSettings["LMS_API_Path"];

        /// <summary>
        /// 物流信息跟踪系统API路径
        /// </summary>
        public static string TISAPIPath = ConfigurationManager.AppSettings["TIS_API_Path"];

        public static string ZONGTENGPath = ConfigurationManager.AppSettings["ZONGTENG_Path"];

        /// <summary>
        /// 福州邮政对接密钥
        /// </summary>
        public static string Postalkey = ConfigurationManager.AppSettings["Postal_key"];

        /// <summary>
        /// 福州邮政对运输方式Code
        /// </summary>
        public static string PostalDockingCode = ConfigurationManager.AppSettings["Postal_Docking_Code"];

        /// <summary>
        /// 福州邮政预报开始时间
        /// </summary>
        public static string PostalTime = ConfigurationManager.AppSettings["Postal_Time"];


        /// <summary>
        /// 政预报开始时间
        /// </summary>
        public static string EUBDHLPostal_Time = ConfigurationManager.AppSettings["EUBDHLPostal_Time"];
        

        /// <summary>
        /// DHL 预报运输方式
        /// </summary>
        public static string DHLShippingMethodCode = ConfigurationManager.AppSettings["DHL_ShippingMethodCode"];

        /// <summary>
        /// EUB 预报运输方式
        /// </summary>
        public static string EUBShippingMethodCode = ConfigurationManager.AppSettings["EUB_ShippingMethodCode"];

        /// <summary>
        /// 上传文件路径
        /// </summary>
        public static string UploadPath = ConfigurationManager.AppSettings["Upload_Path"];

        /// <summary>
        /// DHLBarCode图片物理路径
        /// </summary>
        public static string DHLBarCodePath = ConfigurationManager.AppSettings["DHLBarCodePath"];


        /// <summary>
        /// DHLBarCode图片web路径
        /// </summary>
        public static string WebDHLBarCodePath = ConfigurationManager.AppSettings["WebDHLBarCodePath"];

        /// <summary>
        /// 上传文件的Http路径
        /// </summary>
        public static string UploadWebPath = ConfigurationManager.AppSettings["Upload_Web_Path"];


        public static string UserUploadWebPath = ConfigurationManager.AppSettings["User_Upload_Web_Path"];

        /// <summary>
        /// Excel模板路径
        /// </summary>
        public static string ExcelTemplatePath = UploadPath + @"ExcelTemplate\";

        /// <summary>
        /// PDF模板路径
        /// </summary>
        public static string PdfTemplatePath = UploadPath + @"PDF\";
        /// <summary>
        ///  PDF模板http路径
        /// </summary>
        public static string PdfTemplateWebPath = UploadWebPath + "PDF/";

        public static string PdfUserUploadWebPath = UserUploadWebPath + "PDF/";

        /// <summary>
        /// Excel模板Http路径
        /// </summary>
        public static string ExcelTemplateWebPath = UploadWebPath + "ExcelTemplate\\";
        /// <summary>
        /// 客户端上传凭证Http路径
        /// </summary>
        public static string ClientVoucherPath = UserUploadWebPath + "Voucher/";

        /// <summary>
        /// 凭证路径
        /// </summary>
        public static string VoucherPath = UploadPath + @"Voucher\";

        /// <summary>
        /// 临时文件目录
        /// </summary>
        public static string TemporaryPath = UploadPath + "TemporaryFolder\\";

        public static string TemporaryWebPath = UploadWebPath + "TemporaryFolder\\";



        public static string LMSOrderUploadTemplate = "/deliveryorderuploadtemplate.xls";

        public static string WayBillTrackingNumber = "/wayBillTrackingNumber.xls";

        public static string UploadTrackingNumber = "/uploadTrackingNumber.xls";

        public static string ExportWayBill = "/WayBillInfos";

        public static string ExportInStorageInfo = "/InStorageInfos";

        /// <summary>
        /// 客户订单批量上传
        /// </summary>
        public static string LMSCustomerOrderUploadTemplate = "/customerorderuploadtemplate.xls";

        public static string LMSCustomerPackageUploadTemplate = "CustomerBatchSmallPackage.xls";

        public static string LMSCustomerSinoUSUploadTemplate = "onlyCNUSorderuploadtemplate.xls";

        public static string ReadExcelTemplatePath = ConfigurationManager.AppSettings["ReadExcelTemplatePath"];

        public static string DefaultDateFormat = "yyyy-MM-dd";

        public static string DefaultDatetimeFormat = "yyyy-MM-dd HH:mm:ss";

        public static string DefaultLanguageCode = "CN";

        /// <summary>
        /// 获取国家跟运输方式的api路径
        /// </summary>
        public static string LISWebApi = ConfigurationManager.AppSettings["LIS_API_Path"];
        /// <summary>
        /// 总包编辑时间通用的地点配置字典码
        /// </summary>
        public static Guid TotalPackageAddress = ConfigurationManager.AppSettings["TotalPackageAddress"]!=null? Guid.Parse(ConfigurationManager.AppSettings["TotalPackageAddress"]):Guid.NewGuid();
        /// <summary>
        /// 荷兰邮政小包挂号运输方式ID
        /// </summary>
        public static string NLPOSTShippingMethodID = ConfigurationManager.AppSettings["NLPOSTShippingMethodID"];
        /// <summary>
        /// 俄罗斯挂号、平邮运输方式ID
        /// </summary>
        public static string LithuaniaShippingMethodID = ConfigurationManager.AppSettings["LithuaniaShippingMethodID"];
        /// <summary>
        /// 顺丰CheckWord
        /// </summary>
        public static string SFCheckWord = ConfigurationManager.AppSettings["SFCheckWord"];
        /// <summary>
        /// 顺丰服务商接入码
        /// </summary>
        public static string ClientCode = ConfigurationManager.AppSettings["ClientCode"];
        /// <summary>
        /// 荷兰邮政小包挂号服务商代码
        /// </summary>
        public static string NLPOSTVenderCode = ConfigurationManager.AppSettings["NLPOSTVenderCode"];
        /// <summary>
        /// 俄罗斯挂号、平邮服务商代码
        /// </summary>
        public static string LithuaniaVenderCode = ConfigurationManager.AppSettings["LithuaniaVenderCode"];
        /// <summary>
        /// 俄罗斯挂号、平邮CheckWord
        /// </summary>
        public static string LithuaniaAuthorization = ConfigurationManager.AppSettings["LithuaniaAuthorization"];
        /// <summary>
        /// 需要返回顺丰单号客户，多个已半角逗号分开 C10101,C10102
        /// </summary>
        public static string IsTurnSFNumber = ConfigurationManager.AppSettings["IsTurnSFNumber"];
        /// <summary>
        /// 顺丰荷兰小包运输方式编码
        /// </summary>
        public static string NLPOSTMethodCode = ConfigurationManager.AppSettings["NLPOSTMethodCode"];
        /// <summary>
        /// 俄罗斯挂号、平邮运输方式编码
        /// </summary>
        public static string LithuaniaMethodCode = ConfigurationManager.AppSettings["LithuaniaMethodCode"];

        public static string ClientUpdatePath = ConfigurationManager.AppSettings["ClientUpdatePath"];

        public static string LmsClientLatestVersion = "BuildOn2014-12-26";

        public static string LmsClientLatestName = "LMS.Client.Setup_2014-12-26.exe";

        public static string TestCustomerCode = ConfigurationManager.AppSettings["TestCustomerCode"];
    }

    public static class PermissionRecords
    {
        /// <summary>
        /// 直接出仓权限码
        /// </summary>
        public const int FastOutStorageCode = 120001;

        /// <summary>
        /// 批量取消拦截权限码(异常运单)
        /// </summary>
        public const int BatchCancelAbnormalWayBill = 120002;
        /// <summary>
        /// 批量删除权限码(异常运单)
        /// </summary>
        public const int BatchDeleteAbnormalWayBill = 120003;

        /// <summary>
        /// 批量删除权限码(运单管理)
        /// </summary>
        public const int BatchDelete = 120004;
        /// <summary>
        /// 批量拦截权限码(运单管理)
        /// </summary>
        public const int BatchHoldOn = 120005;
        /// <summary>
        /// 批量修改运单运输方式(运单管理)
        /// </summary>
        public const int BatchModifyShippingMethod = 120006;

        /// <summary>
        /// 直接入仓权限码
        /// </summary>
        public const int FastInStorageCode = 120007;

		/// <summary>
		///无预报异常删除权限码 
		///add by yungchu
		/// </summary>
		public const int NoForecastAbnormalDelete = 120008;
    }

    /// <summary>
    /// 字典信息
    /// </summary>
    public static class DictionaryTypeInfo
    {
        /// <summary>
        /// 运单模板类型
        /// </summary>
        public const string WayBillTemplateType = "DT1308100020";

        /// <summary>
        /// 运单模板规格
        /// </summary>
        public const string WayBillTemplateSpecification = "DT1308100030";




    }
}
