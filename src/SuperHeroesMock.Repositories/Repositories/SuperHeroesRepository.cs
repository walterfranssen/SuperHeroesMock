using MockApi.Domain.Abstract;
using MockApi.Domain.Entities;

namespace MockApi.Repositories
{
    internal class SuperHeroesRepository : ISuperHeroesRepository
    {
        private readonly List<SuperHero> superHeroes;

        public SuperHeroesRepository()
        {
            superHeroes = new List<SuperHero> 
            { 
                new SuperHero { Id = Guid.NewGuid(), Name = "Superman" },
                new SuperHero { Id = Guid.NewGuid(), Name = "Batman" },
                new SuperHero { Id = Guid.NewGuid(), Name = "Spider-Man" },
                new SuperHero { Id = Guid.NewGuid(), Name = "Thor" },
                new SuperHero { Id = Guid.NewGuid(), Name = "Thing" },
                new SuperHero { Id = Guid.NewGuid(), Name = "Mr. Fantastic" },
                new SuperHero { Id = Guid.NewGuid(), Name = "Captain America" },
                new SuperHero { Id = Guid.NewGuid(), Name = "Flash" },
                new SuperHero { Id = Guid.NewGuid(), Name = "Silver Surfer" },
                new SuperHero { Id = Guid.NewGuid(), Name = "Iron man" },
            };

        }
        
        public Task<IEnumerable<SuperHero>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return Task.FromResult(superHeroes.AsEnumerable());
        }

        public Task<SuperHero?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            SuperHero? superHero = superHeroes.FirstOrDefault(x => x.Id == id);

            return Task.FromResult(superHero);
        }
    }
}
