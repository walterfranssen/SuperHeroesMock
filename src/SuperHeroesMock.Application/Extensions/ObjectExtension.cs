using SuperHeroesMock.Domain.Exceptions;

namespace SuperHeroesMock.Application.Extensions
{
    public static class ObjectExtension
    {
        public static void IsNotFound(this object? obj, string? message = "Object not found")
        {
            if (obj == null) throw new NotFoundException(message);
        }
    }
}
