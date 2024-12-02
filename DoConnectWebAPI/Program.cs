using DoConnectEntity;
using Microsoft.EntityFrameworkCore;
using DoConnectRepository.Data;
using DoConnectRepository.Repositories;
using DoConnectService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
var sqlconnectionstring = builder.Configuration.GetConnectionString("sqlcon");
//MyShoppingDbCOntext obj=new MyShoppingDbContext();
builder.Services.AddDbContext<UserDbContext>(options => options.UseSqlServer(sqlconnectionstring));
builder.Services.AddDbContext<UserDbContext>();
builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddScoped<IUserService,UserService>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
