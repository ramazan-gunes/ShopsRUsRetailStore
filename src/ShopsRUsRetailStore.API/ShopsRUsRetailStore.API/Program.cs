using System.Reflection;
using AspNetCoreRateLimit;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using ShopsRUsRetailStore.Core.Extensions.ServiceExtensions;
using ShopsRUsRetailStore.Data.Concrete.EntityFramework.Contexts;
using ShopsRUsRetailStore.Entities.Concrete;
using ShopsRUsRetailStore.Services.Extension;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

//Service Layer Add to Service
builder.Services.AddShopRUsServices();
builder.Services.AddHttpContextAccessor();


//Service Layer Add to Mapping
builder.Services.AddMapping();


builder.Services.AddDbContext<ShopsRUsDbContext>(options =>
{
    options.UseNpgsql(configuration.GetConnectionString("PostgreSQL"), sqlOptions =>
    {
        sqlOptions.MigrationsAssembly("ShopsRUsRetailStore.Data");

    });
});

builder.Services.AddIdentity<User, Role>(options =>
{
    options.User.RequireUniqueEmail = true;
    options.Password.RequireNonAlphanumeric = true;
    options.SignIn.RequireConfirmedEmail = true;
}).AddEntityFrameworkStores<ShopsRUsDbContext>().AddDefaultTokenProviders();


builder.Services.AddControllers().AddFluentValidation(options =>
{
    options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
});


//Core Create Custom FluentValidation Response
builder.Services.UseFluentValidationResponse();



builder.Services.UseApiVersion();
builder.Services.UseSwagger();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddMemoryCache();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();



builder.Services.UseRateLimit(configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    var apiVersionDescriptionProvider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();
    app.UseDeveloperExceptionPage();
    app.UseSwagger(apiVersionDescriptionProvider);
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseIpRateLimiting();

app.Run();
