namespace Test.Rabbit.Consumer.App.Contracts;

// TODO: these are common contracts, but they are shuffled with the domain aggregate folders
public sealed record PaginationParameters(int Skip, int Take); 