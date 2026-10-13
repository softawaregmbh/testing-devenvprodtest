using System.Diagnostics.CodeAnalysis;

namespace TestingDevenvprodtest.Cqs.Exceptions;

public class ForbiddenException(string message) : Exception(message)
{
    [DoesNotReturn]
    public static void Throw<TEntityType>() =>
        throw new ForbiddenException($"Only authorized users may access '{typeof(TEntityType).Name}'");
}
