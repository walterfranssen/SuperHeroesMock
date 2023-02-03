using MediatR;
using Microsoft.AspNetCore.Mvc;
using MockApi.Application.SuperHeroes.Queries.GetAll;

public static class EndpointsExtensions
{ 
    public static void AddSuperHeroesEndpoint(this WebApplication app)
    {
        app.MapGet("/superheroes", ([FromServices] IMediator mediator) => {
            return mediator.Send(new GetAllQueries());
        })
        .WithName("GetAllSuperHeroes")
        .WithOpenApi();
    }
}