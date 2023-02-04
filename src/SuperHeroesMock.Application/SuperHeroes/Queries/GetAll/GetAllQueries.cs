using MediatR;

namespace MockApi.Application.SuperHeroes.Queries.GetAll
{
    public class GetAllQueries : IRequest<IEnumerable<GetAllSuperHeroesDto>>
    {
    }
}
