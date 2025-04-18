using Grpc.Core;

namespace Payment.System.Transactions.Services;

public class TransactionsService: Contracts.TransactionsService.TransactionsServiceBase 
{
    public override Task<CreateTransactionReply> CreateTransaction(CreateTransactionCommand command, ServerCallContext context) {
        return Task.FromResult(new CreateTransactionReply());
    }
}