namespace SuperHeroesMock.Domain.Exceptions
{
    public class NotFoundException : Exception
    {
        public int HttpStatus => 404;
        public NotFoundException(string? message) : base(message) {}
    }
}
