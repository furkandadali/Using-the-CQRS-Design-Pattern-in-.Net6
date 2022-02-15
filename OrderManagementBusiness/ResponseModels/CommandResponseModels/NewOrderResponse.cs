using System;

namespace OrderManagementBusiness.ResponseModels.CommandResponseModels;

public class NewOrderResponse
{

    public long OrderId { get; set; }

    public bool IsSuccess { get; set; }

    public Guid PaymentGuid { get; set; }

}

