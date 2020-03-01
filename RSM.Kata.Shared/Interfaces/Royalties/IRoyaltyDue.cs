using RSM.Kata.Shared.Interfaces.Persons;

namespace RSM.Kata.Shared.Interfaces.Royalties
{
    public interface IRoyaltyDue
    {
        public int Id { get; set; }

        public IPerson Recipient { get; set; }

        public IRoyaltyFee Royalty { get; set; }
        public void PayRoyalty();
    }
}