using Microsoft.Extensions.Configuration.AzureAppConfiguration;
using MockApi.Application;
using MockApi.Repositories;
using System.Collections;

var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("AppConfig");
builder.Configuration.AddAzureAppConfiguration(options => {
    options.Connect(connectionString);
    
    options.Select("SuperHeroDb:*", LabelFilter.Null)
        .ConfigureRefresh(refreshOption => {
            refreshOption.Register("SuperHeroDb:Sentinel", true);
        });
});
builder.Services.AddAzureAppConfiguration();

builder.Services.Configure<SuperHeroDb>(builder.Configuration.GetSection("SuperHeroDb"));

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplication().AddRepositories();

var app = builder.Build();



app.AddSuperHeroesEndpoint();
app.AddSecretSuperHeroesEndpoint();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAzureAppConfiguration();

app.Run();


public class SuperHeroDb
{
    public string? CollectionName { get; set; }
    public string? AccountName { get; set; }
}