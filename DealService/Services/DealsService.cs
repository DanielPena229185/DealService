using Grpc.Core;

namespace DealService;

public class DealsService: Deals.DealsBase
{
    public override Task<GetDealByIdResponse> GetDealById(GetDealByIdRequest request, ServerCallContext context)
    {
        IDealDAO dealDAO = new DealDAO();
        string dealId = request.Id;
        
        return null;
    }

    public override Task<DealEntity> CreateDeal(DealEntity deal, ServerCallContext context)
    {
        return Task.FromResult(deal);
    }
}
