var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapPost("/create", (int id, string orderName) =>
{
    return $"Order of id: {id} & Name : {orderName} has been created";
}).WithName("CreateOrder").WithDescription("This endpoint is using to create the order")
.WithOpenApi();

app.Run();
