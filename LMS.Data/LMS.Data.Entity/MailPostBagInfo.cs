//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Entity
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using LighTake.Infrastructure.Seedwork;
    
    public partial class MailPostBagInfo : Entity
    {
    
        ICollection<MailTotalPackageOrPostBagRelational> _mailTotalPackageOrPostBagRelationals;
        ICollection<MailExchangeBagLog> _mailExchangeBagLogs;
        ICollection<MailExchangeBagLog> _mailExchangeBagLogs1;
        ICollection<MailReturnGoodsLog> _mailReturnGoodsLogs;
    
    
        public virtual string PostBagNumber { get; set; }
        public virtual string OutStorageID { get; set; }
        public virtual string CountryCode { get; set; }
        public virtual bool IsBattery { get; set; }
        public virtual string FuPostBagNumber { get; set; }
        public virtual Nullable<System.DateTime> ScanTime { get; set; }
        public virtual System.DateTime CreatedOn { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual System.DateTime LastUpdatedOn { get; set; }
        public virtual string LastUpdatedBy { get; set; }
        public virtual int TrackStatus { get; set; }
        public virtual decimal TotalWeight { get; set; }
        public virtual string ScanBy { get; set; }
    
        public virtual OutStorageInfo OutStorageInfo { get; set; }
        public virtual ICollection<MailTotalPackageOrPostBagRelational> MailTotalPackageOrPostBagRelationals 
    	{
            get { return _mailTotalPackageOrPostBagRelationals  ?? (_mailTotalPackageOrPostBagRelationals  = new List<MailTotalPackageOrPostBagRelational>()); }
            protected set { _mailTotalPackageOrPostBagRelationals  = value; }
        }
    
        public virtual ICollection<MailExchangeBagLog> MailExchangeBagLogs 
    	{
            get { return _mailExchangeBagLogs  ?? (_mailExchangeBagLogs  = new List<MailExchangeBagLog>()); }
            protected set { _mailExchangeBagLogs  = value; }
        }
    
        public virtual ICollection<MailExchangeBagLog> MailExchangeBagLogs1 
    	{
            get { return _mailExchangeBagLogs1  ?? (_mailExchangeBagLogs1  = new List<MailExchangeBagLog>()); }
            protected set { _mailExchangeBagLogs1  = value; }
        }
    
        public virtual ICollection<MailReturnGoodsLog> MailReturnGoodsLogs 
    	{
            get { return _mailReturnGoodsLogs  ?? (_mailReturnGoodsLogs  = new List<MailReturnGoodsLog>()); }
            protected set { _mailReturnGoodsLogs  = value; }
        }
    
    }
}
