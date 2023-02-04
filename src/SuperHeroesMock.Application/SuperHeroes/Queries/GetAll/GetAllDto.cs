namespace MockApi.Application.SuperHeroes.Queries.GetAll
{
    public class GetAllSuperHeroesDto
    {
        public required Guid Id { get; set; }
        public required string Name { get; set; }
    }
}
