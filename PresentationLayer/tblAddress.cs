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
    
    public partial class tblAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAddress()
        {
            this.tblCustomers = new HashSet<tblCustomer>();
            this.tblCustomers1 = new HashSet<tblCustomer>();
            this.tblEmployees = new HashSet<tblEmployee>();
        }
    
        public int Id { get; set; }
        public string COUNTRY { get; set; }
        public string STATE { get; set; }
        public string DISTRICT { get; set; }
        public string CITY { get; set; }
        public string PLACE { get; set; }
        public string ADDRESS { get; set; }
        public string PHONENUMBER { get; set; }
        public string EMAIL { get; set; }
        public Nullable<int> ADDRESSTYPEID { get; set; }
        public bool ISACTIVE { get; set; }
        public Nullable<System.DateTime> CREATEDDATE { get; set; }
        public Nullable<int> CREATEDBY { get; set; }
        public Nullable<System.DateTime> MODIFIEDDATE { get; set; }
        public Nullable<int> MODIFIEDBY { get; set; }
    
        public virtual tblAddressType tblAddressType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomer> tblCustomers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCustomer> tblCustomers1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmployee> tblEmployees { get; set; }
    }
}
