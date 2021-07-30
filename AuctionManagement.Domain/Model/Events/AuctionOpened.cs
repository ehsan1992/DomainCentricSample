using System;
using Framework.Domain;

namespace AuctionManagement.Domain.Model.Events
{
    public class AuctionOpened:DomainEvent
    {
        public long Id  { get; private set; }
        public string ProductName  { get; private set; }
        public long StartingPrice  { get; private set; }
        public DateTime EndDAteTime  { get; private set; }

        public AuctionOpened(long id, string productName, long startingPrice, DateTime endDateTime)
        {
            Id = id;
            ProductName = productName;
            StartingPrice = startingPrice;
            EndDAteTime = endDateTime;
        }
    }
}
