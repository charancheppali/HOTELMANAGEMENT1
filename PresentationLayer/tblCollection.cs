//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentationLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCollection
    {
        public int Id { get; set; }
        public decimal AMOUNT { get; set; }
        public Nullable<decimal> PENDINGAMOUNT { get; set; }
        public Nullable<int> INVOICEID { get; set; }
        public bool ISACTIVE { get; set; }
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        public Nullable<int> CREATEDBY { get; set; }
        public Nullable<System.DateTime> MODIFIEDDATE { get; set; }
        public Nullable<int> MODIFIEDBY { get; set; }
    
        public virtual tblInvoice tblInvoice { get; set; }
    }
}