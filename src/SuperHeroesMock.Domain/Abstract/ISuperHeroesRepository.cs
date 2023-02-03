using MockApi.Domain.Entities;

namespace MockApi.Domain.Abstract
{
    public interface ISuperHeroesRepository
    {
        Task<IEnumerable<SuperHero>> GetAll();
    }
}
