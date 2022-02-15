using System;
using OrderManagementBusiness.RequestModels.QueryRequestModels;
using OrderManagementBusiness.ResponseModels.QueryResponseModels;

namespace OrderManagementBusiness.Interfaces.IQueryHandlers;

public interface IGetOrderById
{
    public OrderResponse GetOrderById(OrderRequest m);
}
