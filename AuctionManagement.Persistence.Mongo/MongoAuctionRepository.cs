using AuctionManagement.Domain.Model;
using System;

namespace AuctionManagement.Persistence.Mongo
{
    public class MongoAuctionRepository : IAuctionRepository
    {
        public Auction GetById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
