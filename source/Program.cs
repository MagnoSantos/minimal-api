using Data;
using ViewModel;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/v1/customers", (DataContext context) => {
    var customers = context.Customers.ToList();
    return Results.Ok(customers);
}).Produces<Customer>();

app.MapPost("v1/customers", (DataContext context, CreateCustomerViewModel model) 
    => {
        var customer = model.MapTo();

        if (!model.IsValid) 
            return Results.BadRequest(model.Notifications);

        context.Customers.Add(customer);
        context.SaveChanges();

        return Results.Created($"/v1/customers/{customer.id}", customer);
    });

app.Run();
