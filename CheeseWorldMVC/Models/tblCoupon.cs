//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CheeseWorldMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCoupon
    {
        public tblCoupon()
        {
            this.tblTransactions = new HashSet<tblTransaction>();
        }
    
        public int CouponID { get; set; }
        public string CouponType { get; set; }
        public Nullable<decimal> CouponValue { get; set; }
        public Nullable<int> CouponCode { get; set; }
    
        public virtual ICollection<tblTransaction> tblTransactions { get; set; }
    }
}
