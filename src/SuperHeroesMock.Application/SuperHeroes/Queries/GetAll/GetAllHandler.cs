using MediatR;
using MockApi.Domain.Abstract;

namespace MockApi.Application.SuperHeroes.Queries.GetAll
{
    public class GetAllHandler : IRequestHandler<GetAllQueries, IEnumerable<GetAllSuperHeroesDto>>
    {
        private readonly ISuperHeroesRepository superHeroesRepository;

        public GetAllHandler(ISuperHeroesRepository superHeroesRepository)
        {
            this.superHeroesRepository = superHeroesRepository;
        }

        public async Task<IEnumerable<GetAllSuperHeroesDto>> Handle(GetAllQueries request, CancellationToken cancellationToken)
        {
            var entities = await superHeroesRepository.GetAllAsync();
            if (entities == null) return new List<GetAllSuperHeroesDto>();

            var dtos = entities.Select(x => new GetAllSuperHeroesDto { Id = x.Id, Name = x.Name });
            return dtos.ToList();
        }
    }
}
