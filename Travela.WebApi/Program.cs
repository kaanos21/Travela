using Travela.BusinessLayer.Abstract;
using Travela.BusinessLayer.Concrete;
using Travela.DataAccesLayer.Abstract;
using Travela.DataAccesLayer.Context;
using Travela.DataAccesLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<TravelaContext>();

builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService,CategoryManager>();

builder.Services.AddScoped<IDestinationDal, EfDestinationDal>();
builder.Services.AddScoped<IDestinationService, DestinationManager>();

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
