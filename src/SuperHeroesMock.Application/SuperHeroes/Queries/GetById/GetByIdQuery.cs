using MediatR;

namespace SuperHeroesMock.Application.SuperHeroes.Queries.GetById
{
    public record GetByIdQuery(Guid Id) : IRequest<SuperHeroDetailDto>;
}
