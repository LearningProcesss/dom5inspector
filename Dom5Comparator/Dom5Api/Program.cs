using Dom5Api.Dto.Request;
using Dom5Logic.Odm.Aggrator;
using Dom5Logic.Odm.Aggrator.Dto;
using Dom5Logic.Odm.Mapper;
using Dom5Logic.Odm.Persistence.Context;
using Dom5Logic.Odm.Persistence.Models;
using Dom5Logic.Odm.Persistence.Repository;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IContext, ContextData>(service => ActivatorUtilities.CreateInstance<ContextData>(service, "/workspaces/dom5inspector/Dom5Comparator/Dom5Logic/Odm/Persistence/gamedata"));
builder.Services.AddSingleton<IMapping, Mapping>();
builder.Services.AddSingleton(typeof(IGenericRepository<>), typeof(GenericCsvRepository<>));
builder.Services.AddSingleton<IGenericBuilder<WeaponsAggregate>, WeaponBuilder>();
builder.Services.AddSingleton<IGenericBuilder<BaseUAggregate>, BaseUBuilder>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.MapGet("/units/{id}", (int id, IGenericBuilder<BaseUAggregate> builder) =>
{
    return builder.Build(id);
}).WithName("GetUnitsById");
// [FromQuery(Name = "compare")] QueryUnitCompare? compare,
app.MapGet("/units", (IGenericRepository<BaseU> repository, IGenericBuilder<BaseUAggregate> builder) =>
{
    return Results.Json(repository.Get().Select(baseU => builder.Build(baseU.id)).Take(10));
});

app.MapGet("/units/{leftId}/compare/{rightId}", (int leftId, int rightId, IGenericBuilder<BaseUAggregate> baseUBuilder) =>
{
    var leftUnit = baseUBuilder.Build(leftId);

    if (leftUnit == null)
    {
        return Results.NotFound();
    }

    var rightUnit = baseUBuilder.Build(rightId);

    if (rightUnit == null)
    {
        return Results.NotFound();
    }

    

    return Results.Json("");
});

app.Run();

record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}