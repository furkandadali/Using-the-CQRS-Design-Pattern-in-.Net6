using System;
using OrderManagementBusiness.RequestModels.CommandRequestModels;
using OrderManagementBusiness.ResponseModels.CommandResponseModels;

namespace OrderManagementBusiness.Interfaces.ICommandHandlers;

public interface ICreateNewOrder
{
    public NewOrderResponse CreateNewOrder(NewOrderRequest m);
}

