namespace Domain.Interface
{
    public interface ICreditUpdater
    {
        decimal CreditDeductor(string username, decimal amount);
        decimal CreditIncreaser(string username, decimal amount);
    }
}
