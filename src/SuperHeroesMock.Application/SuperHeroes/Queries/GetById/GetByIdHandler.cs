using MediatR;
using MockApi.Domain.Abstract;
using MockApi.Domain.Entities;
using SuperHeroesMock.Application.Extensions;

namespace SuperHeroesMock.Application.SuperHeroes.Queries.GetById
{
    internal class GetByIdHandler(ISuperHeroesRepository superHeroesRepository) : IRequestHandler<GetByIdQuery, SuperHeroDetailDto>
    {
        private readonly ISuperHeroesRepository superHeroesRepository = superHeroesRepository;

        public async Task<SuperHeroDetailDto> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            SuperHero? superHero = await superHeroesRepository.GetByIdAsync(request.Id, cancellationToken);
            superHero.IsNotFound();

            return new SuperHeroDetailDto(superHero.Name, superHero.Id);
        }
    }
}
