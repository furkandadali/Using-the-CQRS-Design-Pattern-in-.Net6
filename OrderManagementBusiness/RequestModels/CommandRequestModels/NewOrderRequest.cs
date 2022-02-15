using System;

namespace OrderManagementBusiness.RequestModels.CommandRequestModels;

public class NewOrderRequest
{

	public long ProductId { get; set; }

	public Guid PaymentGuid { get; set; }

	public int OrderEmployeId {get; set;}

	public DateTime OrderDate { get; set; }

}

