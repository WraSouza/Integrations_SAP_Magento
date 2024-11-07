using System.Reflection;
using Application.Queries.QueriesSAP.GetBusinessPartner;
using Domain.DTOs.DTOSAP;
using Domain.Entities.EntitiesSAP;
using Domain.Repositories.MagentoRepositories;
using Domain.Repositories.SAPRepositories;
using Infrastructure.Helpers;
using Infrastructure.Repositories.RepositoriesMagento;
using Infrastructure.Repositories.RepositoriesSAP;
using Microsoft.Extensions.DependencyInjection;
using WebAPI.Controllers.ControllersMagento;
using WebAPI.Controllers.ControllersSAP;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<LoginRequest>(builder.Configuration.GetSection("SAPLogin"));

builder.Services.AddSingleton<IBusinessPartnerRepository, BusinessPartnerRepository>();
builder.Services.AddSingleton<IOrdersRepository, OrdersRepository>();

builder.Services.AddSingleton<LoginHelper>();

builder.Services.AddMemoryCache();

builder.Services.AddSwaggerGen(opt => 
{
    opt.SwaggerDoc("v1", new () { Title = "API SAP Magento", Version = "v1" });
});

builder.Services.AddMediatR(cfg => { cfg.RegisterServicesFromAssemblies(typeof(GetBusinessPartnerQuery).Assembly); });

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGroup("")
.BusinessPartnerEndpoint()
.WithTags("SAP - Business Partner");

app.MapGroup("")
.OrdersEndpoint()
.WithTags("Magento - Orders");

app.UseHttpsRedirection();

app.Run();

