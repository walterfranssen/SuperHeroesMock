using MediatR;
using MockApi.Domain.Abstract;

namespace MockApi.Application.SuperHeroes.Queries.GetAll
{
    public class GetAllHandler : IRequestHandler<GetAllQueries, IEnumerable<GetAllDto>>
    {
        private readonly ISuperHeroesRepository superHeroesRepository;

        public GetAllHandler(ISuperHeroesRepository superHeroesRepository)
        {
            this.superHeroesRepository = superHeroesRepository;
        }

        public async Task<IEnumerable<GetAllDto>> Handle(GetAllQueries request, CancellationToken cancellationToken)
        {
            var entities = await superHeroesRepository.GetAll();
            if (entities == null) return new List<GetAllDto>();

            var dtos = entities.Select(x => new GetAllDto { Id = x.Id, Name = x.Name });
            return dtos.ToList();
        }
    }
}
