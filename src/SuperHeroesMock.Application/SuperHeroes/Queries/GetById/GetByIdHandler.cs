using MediatR;
using MockApi.Domain.Abstract;
using MockApi.Domain.Entities;
using SuperHeroesMock.Application.Extensions;

namespace SuperHeroesMock.Application.SuperHeroes.Queries.GetById
{
    internal class GetByIdHandler : IRequestHandler<GetByIdQuery, SuperHeroDetailDto>
    {
        private readonly ISuperHeroesRepository superHeroesRepository;

        public GetByIdHandler(ISuperHeroesRepository superHeroesRepository)
        {
            this.superHeroesRepository = superHeroesRepository;
        }
        public async Task<SuperHeroDetailDto> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            SuperHero? superHero = await superHeroesRepository.GetByIdAsync(request.Id, cancellationToken);
            superHero.IsNotFound();

            return new SuperHeroDetailDto { Id = superHero.Id, Name = superHero.Name };
        }
    }
}
