// Inicializa los objetos Market y Product antes de crear el objeto Deal
using DealService;

IDealObserver dealObserver = new DealPublicated();

Product product = new Product{
    Id = "1",
    Name = "Product 1"
};
Market market = new Market{
    Id = "1",
    Name = "Market 1"
};
Deal deal = new Deal{
    Product = product,
    Market = market,
    Price = 100,
    Date = DateTime.Now,
    Description = "Description"
};
DealDAO dealDAO = new DealDAO();
dealDAO.Attach(dealObserver);
dealDAO.InsertDeal(deal);