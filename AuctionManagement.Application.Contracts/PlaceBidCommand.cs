using Framework.Application;

namespace AuctionManagement.Application.Contracts
{
    public class PlaceBidCommand : ICommand
    {
        public long AuctionId { get; set; }
        public long BidderId { get; set; }
        public long Amount { get; set; }
    }
}