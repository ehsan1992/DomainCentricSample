
using System.Threading.Tasks;

namespace AuctionManagement.Domain.Model
{
    public interface IAuctionRepository
    {
        Auction GetById(long id);
        Task Add(Auction auction);
    }
}
