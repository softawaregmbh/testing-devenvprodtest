using Microsoft.EntityFrameworkCore;
using TestingDevenvprodtest.EntityFramework;

namespace TestingDevenvprodtest.Cqs.Items.GetItemById;

public sealed class GetItemByIdQueryHandler(TestingDevenvprodtestContext context)
    : IRequestHandler<GetItemByIdQuery, ItemDto>
{
    public async Task<ItemDto> HandleAsync(GetItemByIdQuery request, CancellationToken cancellationToken)
    {
        // TODO: add code to retrieve item from database
        await context.Database.ExecuteSqlRawAsync("SELECT 1", cancellationToken);

        return new ItemDto(request.Id, "Item", DateTimeOffset.Now);
    }
}
