using MediatR;

namespace SuperHeroesMock.Application.SuperHeroes.Queries.GetById
{
    public class GetByIdQuery : IRequest<SuperHeroDetailDto>
    {
        public GetByIdQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }
    }
}
