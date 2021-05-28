
namespace AuctionManagement.Domain.Model
{
    public interface IAuctionRepository
    {
        Auction GetById(long id);
    }
}
