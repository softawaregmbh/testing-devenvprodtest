using System.Diagnostics.CodeAnalysis;

namespace TestingDevenvprodtest.Cqs.Exceptions;

public class UnauthorizedException(string message) : Exception(message)
{
    [DoesNotReturn]
    public static void Throw<TEntityType>() =>
        throw new UnauthorizedException($"Only authorized users may access '{typeof(TEntityType).Name}'");
}
