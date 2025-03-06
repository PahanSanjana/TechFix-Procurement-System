using Microsoft.EntityFrameworkCore;
using TechFix.API.Data;

var builder = WebApplication.CreateBuilder(args);
var conn = "Data Source=DESKTOP-MJBLCPV;Initial Catalog=DD database;Integrated Security=True;TrustServerCertificate=Yes";
builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer(conn));
builder.Services.AddScoped<IProductRepo, ProductRepo>();
builder.Services.AddScoped<IOrderRepo, OrderRepo>();
builder.Services.AddScoped<ISaleRepo, SaleRepo>();
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
builder.Services.AddScoped<IUserRepo, UserRepo>();

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
