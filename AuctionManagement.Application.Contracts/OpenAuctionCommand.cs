using System;
using Framework.Application;

namespace AuctionManagement.Application.Contracts
{
    public class OpenAuctionCommand : ICommand
    {
        public string Product { get; set; }
        public int StartingPrice { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}
