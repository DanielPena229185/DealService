namespace DealService;

public class ParseProtoEntity
{
    public static DealEntity ParseDeal(Deal deal)
    {
        ProductEntity product = new ProductEntity
        {
            Id = deal.Product.Id,
            Name = deal.Product.Name,
        };
        MarketEntity market = new MarketEntity
        {
            Id = deal.Market.Id,
            Name = deal.Market.Name,
        };
        double price = Double.Parse(deal.Price.ToString());
        string date = deal.Date.ToString();
        DealEntity dealEntity = new DealEntity
        {
            Id = deal.Id,
            Description = deal.Description,
            Price = price,
            Date = date,
            Product = product,
            Market = market,

        };
        return dealEntity; 
    }

    public static Deal ParseDealEntity(DealEntity dealEntity)
    {
        Product product = new Product
        {
            Id = dealEntity.Product.Id,
            Name = dealEntity.Product.Name,
        };
        Market market = new Market
        {
            Id = dealEntity.Market.Id,
            Name = dealEntity.Market.Name,
        };
        decimal price = (decimal)dealEntity.Price;
        DateTime date = DateTime.Parse(dealEntity.Date);
        Deal deal = new Deal
        {
            Id = dealEntity.Id,
            Description = dealEntity.Description,
            Price = price,
            Date = new DateTime(),
            Product = product,
            Market = market,
        };
        return deal;
    }
}
