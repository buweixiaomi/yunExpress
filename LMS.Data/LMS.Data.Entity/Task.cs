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
    
    public partial class Task : Entity
    {
        public virtual long TaskID { get; set; }
        public virtual int TaskType { get; set; }
        public virtual string TaskKey { get; set; }
        public virtual int Status { get; set; }
        public virtual string Body { get; set; }
        public virtual int Times { get; set; }
        public virtual string Error { get; set; }
        public virtual System.DateTime CreateOn { get; set; }
    }
}