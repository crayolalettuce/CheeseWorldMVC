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
    
    public partial class tblMiscProduct
    {
        public tblMiscProduct()
        {
            this.tblMiscRatings = new HashSet<tblMiscRating>();
            this.tblReservations = new HashSet<tblReservation>();
            this.tblTransactions = new HashSet<tblTransaction>();
        }
    
        public int MiscProductID { get; set; }
        public string MiscProductName { get; set; }
        public Nullable<decimal> MiscProductCostPrice { get; set; }
        public Nullable<decimal> MiscProductQuantity { get; set; }
        public string MiscProductProvider { get; set; }
        public Nullable<decimal> MiscProductRetailPrice { get; set; }
        public string MiscProductType { get; set; }
        public Nullable<decimal> MiscProductScore { get; set; }
        public string MiscProductDescription { get; set; }
        public Nullable<System.DateTime> MiscProductPurchaseDate { get; set; }
    
        public virtual ICollection<tblMiscRating> tblMiscRatings { get; set; }
        public virtual ICollection<tblReservation> tblReservations { get; set; }
        public virtual ICollection<tblTransaction> tblTransactions { get; set; }
    }
}
