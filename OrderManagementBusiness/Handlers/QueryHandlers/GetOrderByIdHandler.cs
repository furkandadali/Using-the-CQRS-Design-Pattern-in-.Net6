using System;
using OrderManagementBusiness.RequestModels.QueryRequestModels;
using OrderManagementBusiness.ResponseModels.QueryResponseModels;
using OrderManagementBusiness.Interfaces.IQueryHandlers;

namespace OrderManagementBusiness.Handlers.QueryHandlers;

public class GetOrderByIdHandler : IGetOrderById
{
	public OrderResponse GetOrderById(OrderRequest m)
    {
        #region
        //You can put Business Logic Here! (ORM,Connection String etc.)
        #endregion

        return new OrderResponse()
        {
            IsSuccess = true,
            PaymentGuid = new Guid("65d5f781-d557-44df-baa5-c1a4f81aa6ee"),
            OrderDate = DateTime.Now.AddMinutes(-10),
            OrderEmployeId = 3,
            OrderId = 11,
            ProductId = 524957
        };
    }
}

