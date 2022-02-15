
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<OrderManagementBusiness.Interfaces.ICommandHandlers.ICreateNewOrder, OrderManagementBusiness.Handlers.CommandHandlers.CreateNewOrderHandler>();
builder.Services.AddScoped<OrderManagementBusiness.Interfaces.IQueryHandlers.IGetOrderById, OrderManagementBusiness.Handlers.QueryHandlers.GetOrderByIdHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

