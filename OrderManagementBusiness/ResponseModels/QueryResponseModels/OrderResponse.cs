using System;

namespace OrderManagementBusiness.ResponseModels.QueryResponseModels;

public class OrderResponse
{
	public long ProductId { get; set; }

	public long OrderId { get; set; }

	public bool IsSuccess { get; set; }

	public Guid PaymentGuid { get; set; }

	public int OrderEmployeId { get; set; }

	public DateTime OrderDate { get; set; }
}
