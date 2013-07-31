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
    
    public partial class tblCheese
    {
        public tblCheese()
        {
            this.tblCheeseRatings = new HashSet<tblCheeseRating>();
            this.tblReservations = new HashSet<tblReservation>();
            this.tblTransactions = new HashSet<tblTransaction>();
        }
    
        public int CheeseID { get; set; }
        public string CheeseName { get; set; }
        public Nullable<decimal> CheeseCostPrice { get; set; }
        public Nullable<decimal> CheeseQuantity { get; set; }
        public string CheeseProvider { get; set; }
        public Nullable<System.DateTime> CheesePurchaseDate { get; set; }
        public Nullable<System.DateTime> CheeseExpirationDate { get; set; }
        public Nullable<decimal> CheeseRetailPrice { get; set; }
        public string CheeseType { get; set; }
        public string CheesePasturized { get; set; }
        public Nullable<decimal> CheeseScore { get; set; }
        public string CheeseDescription { get; set; }
        public Nullable<int> CheeseGroup { get; set; }
    
        public virtual ICollection<tblCheeseRating> tblCheeseRatings { get; set; }
        public virtual ICollection<tblReservation> tblReservations { get; set; }
        public virtual ICollection<tblTransaction> tblTransactions { get; set; }
    }
}
