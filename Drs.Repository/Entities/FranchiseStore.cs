//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Drs.Repository.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class FranchiseStore
    {
        public FranchiseStore()
        {
            this.FranchiseStoreGeoMap = new HashSet<FranchiseStoreGeoMap>();
            this.FranchiseStoreOffLine = new HashSet<FranchiseStoreOffLine>();
            this.OrderToStore = new HashSet<OrderToStore>();
            this.StoreAddressDistribution = new HashSet<StoreAddressDistribution>();
            this.FranchisePhone = new HashSet<FranchisePhone>();
        }
    
        public int FranchiseStoreId { get; set; }
        public int FranchiseId { get; set; }
        public string Name { get; set; }
        public string UserIdIns { get; set; }
        public string UserIdUpd { get; set; }
        public System.DateTime DatetimeIns { get; set; }
        public Nullable<System.DateTime> DatetimeUpd { get; set; }
        public int AddressId { get; set; }
        public bool IsObsolete { get; set; }
        public string WsAddress { get; set; }
        public string ManageUserId { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual AspNetUsers AspNetUsers1 { get; set; }
        public virtual AspNetUsers AspNetUsers2 { get; set; }
        public virtual Franchise Franchise { get; set; }
        public virtual ICollection<FranchiseStoreGeoMap> FranchiseStoreGeoMap { get; set; }
        public virtual ICollection<FranchiseStoreOffLine> FranchiseStoreOffLine { get; set; }
        public virtual ICollection<OrderToStore> OrderToStore { get; set; }
        public virtual ICollection<StoreAddressDistribution> StoreAddressDistribution { get; set; }
        public virtual StoreStatus StoreStatus { get; set; }
        public virtual ICollection<FranchisePhone> FranchisePhone { get; set; }
    }
}
