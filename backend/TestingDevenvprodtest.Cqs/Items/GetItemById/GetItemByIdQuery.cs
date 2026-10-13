namespace TestingDevenvprodtest.Cqs.Items.GetItemById;

public record GetItemByIdQuery(Guid Id) : IQuery<ItemDto>;
