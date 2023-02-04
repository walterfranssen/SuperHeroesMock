using MediatR;
using Microsoft.AspNetCore.Mvc;
using MockApi.Application.SuperHeroes.Queries.GetAll;
using SuperHeroesMock.Application.SuperHeroes.Queries.GetById;

public static class EndpointsExtensions
{ 
    public static void AddSuperHeroesEndpoint(this WebApplication app)
    {
        app.MapGet("/superheroes", ([FromServices] IMediator mediator) => {
            return mediator.Send(new GetAllQueries());
        })
        .WithName("GetAllSuperHeroes")
        .WithOpenApi();

        //detail endpoint
        app.MapGet("/superheroes/{id:Guid}", ([FromRoute] Guid id, [FromServices] IMediator mediator) => {
            return mediator.Send(new GetByIdQuery(id));
        })
        .WithName("GetSuperheroById")
        .WithOpenApi();
    }
}