namespace AuctionManagement.Domain.Model
{
    public class AuctionId
    {
        public AuctionId(long value)
        {
            Value = value;
        }
        public long Value { get; private set; }
    }
}