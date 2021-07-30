using System;
using AuctionManagement.Domain.Model.Events;
using Framework.Domain;

namespace AuctionManagement.Domain.Model
{
    public class Auction : AggregateRoot<AuctionId>
    {
        public  string ProductName;
        public  long StartingPrice;
        public  DateTime EndDateTime;

        public Auction(AuctionId id,string productName,long startingPrice,DateTime endDateTime)
        {
            ProductName = productName;
            StartingPrice = startingPrice;
            EndDateTime = endDateTime;
            Id = id;
            Causes(new AuctionOpened(this.Id.Value,productName,startingPrice,endDateTime));
        }
    }
}
