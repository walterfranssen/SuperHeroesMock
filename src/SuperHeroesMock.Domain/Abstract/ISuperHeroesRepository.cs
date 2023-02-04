using MockApi.Domain.Entities;

namespace MockApi.Domain.Abstract
{
    public interface ISuperHeroesRepository
    {
        Task<IEnumerable<SuperHero>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<SuperHero?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}
