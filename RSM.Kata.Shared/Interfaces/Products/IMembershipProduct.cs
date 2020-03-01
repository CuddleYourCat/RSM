using RSM.Kata.Shared.Interfaces.Notification;

namespace RSM.Kata.Shared.Interfaces.Products
{
    public interface IMembershipProduct : IProduct
    {
        public void Activate();
        public void Update(MembershipDto dto);

        public void Notify(INotifyService notifyService);
    }
}