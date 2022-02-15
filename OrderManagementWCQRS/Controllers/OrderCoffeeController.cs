using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using OrderManagementBusiness.RequestModels.CommandRequestModels;
using OrderManagementBusiness.ResponseModels.CommandResponseModels;
using OrderManagementBusiness.Interfaces.ICommandHandlers;
using OrderManagementBusiness.Interfaces.IQueryHandlers;
using OrderManagementBusiness.RequestModels.QueryRequestModels;
using OrderManagementBusiness.ResponseModels.QueryResponseModels;

namespace OrderManagementWCQRS.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class OrderCoffeeController : ControllerBase
{

    private readonly ICreateNewOrder _createNewOrder;
    private readonly IGetOrderById _getOrderById;

    public OrderCoffeeController(ICreateNewOrder createNewOrder, IGetOrderById getOrderById)
    {
        _createNewOrder = createNewOrder;
        _getOrderById = getOrderById;
    }

    [HttpPost]
    public ActionResult CreateNewOrder(NewOrderRequest m)
    {
        if (m.ProductId != 0)
        {
            var result = _createNewOrder.CreateNewOrder(m);
            return result is not null ? Ok(new JsonResult(result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK }) : Ok(new JsonResult(null) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status204NoContent });
        }
        else
        {
            return Ok("please check input parameters!");
        }
    }

    [HttpGet]
    public ActionResult GetOrderById(OrderRequest m)
    {
        if (m.OrderId != 0)
        {
            var result = _getOrderById.GetOrderById(m);
            return result is not null ? Ok(new JsonResult(result) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status200OK}) : Ok(new JsonResult(null) { StatusCode = Microsoft.AspNetCore.Http.StatusCodes.Status204NoContent });
        }
        else
        {
            return Ok("please check input parameters!");
        }
    }
}