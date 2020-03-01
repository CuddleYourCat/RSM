using System;
using RSM.Kata.Shared.Interfaces.Persons;
using RSM.Kata.Shared.Interfaces.Products;
using RSM.Kata.Shared.Interfaces.Royalties;

namespace RSM.Kata.DTO
{
    public class Book : IPhysicalProduct, IRoyaltyDue
    {
        #region PhysicalProduct members
        public int Id { get; set; }
        public string ProductSKU { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public void GeneratePackingSlip()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region RoyaltyDue members
        public IPerson Recipient { get; set; }
        public IRoyaltyFee Royalty { get; set; }

        public void PayRoyalty()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}