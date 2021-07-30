using AuctionManagement.Domain.Model;
using System;
using System.Threading.Tasks;

namespace AuctionManagement.Persistence.Mongo
{
    public class MongoAuctionRepository : IAuctionRepository
    {
        public Auction GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task Add(Auction auction)
        {
            // save auction with event in same transaction
            return Task.CompletedTask;
        }
    }
}
