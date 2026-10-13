using Microsoft.EntityFrameworkCore;
using TestingDevenvprodtest.EntityFramework;

namespace TestingDevenvprodtest.Cqs.Items.SaveItem;

public class SaveItemCommandHandler(TestingDevenvprodtestContext context) : IRequestHandler<SaveItemCommand, NoResult>
{
    public async Task<NoResult> HandleAsync(SaveItemCommand request, CancellationToken cancellationToken)
    {
        // TODO: add code to save item to database
        await context.Database.ExecuteSqlRawAsync("SELECT 1", cancellationToken);

        return NoResult.Value;
    }
}
