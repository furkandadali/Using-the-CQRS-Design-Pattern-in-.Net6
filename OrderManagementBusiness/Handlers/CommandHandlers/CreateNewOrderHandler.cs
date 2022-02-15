using System;
using OrderManagementBusiness.RequestModels.CommandRequestModels;
using OrderManagementBusiness.ResponseModels.CommandResponseModels;
using OrderManagementBusiness.Interfaces.ICommandHandlers;

namespace OrderManagementBusiness.Handlers.CommandHandlers;

public class CreateNewOrderHandler : ICreateNewOrder
{
	public NewOrderResponse CreateNewOrder(NewOrderRequest m)
	{
        #region
        //You can put Business Logic Here! (ORM,Connection String etc.)
        #endregion

        return new NewOrderResponse()
        {
            IsSuccess = true,
            OrderId = 12,
            PaymentGuid = new Guid("65d5f781-d557-44df-baa5-c1a4f81aa6ee")
        };
    }
}

