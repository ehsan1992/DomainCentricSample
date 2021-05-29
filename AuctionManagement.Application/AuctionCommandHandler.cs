using AuctionManagement.Application.Contracts;
using AuctionManagement.Domain.Model;
using Framework.Application;
using System;
using System.Threading.Tasks;

namespace AuctionManagement.Application
{
    public class AuctionCommandHandler : ICommandHandler<PlaceBidCommand>,
        ICommandHandler<OpenAuctionCommand>
    {
        private readonly IAuctionRepository _auctionRepository;

        public AuctionCommandHandler(IAuctionRepository auctionRepository)
        {
            _auctionRepository = auctionRepository;
        }

        public async Task Handle(PlaceBidCommand command)
        {
            throw new NotImplementedException();
        }

        public async Task Handle(OpenAuctionCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
