using System.Dynamic;

class Account
{
    public Holder holder;
    public string Agency { get; }
    public string AccountNumber { get; }
    private decimal balance = (decimal)0;

    public decimal Balance
    {
        get => balance;
        set => balance = value;
    }

    private decimal limit = (decimal) 0;

    public decimal Limit
    {
        get => limit;
        set => limit = value;
    }

    public Account(Holder holderAccount, string agency, string accountNumber, decimal balanceAccount, decimal limitAccount)
    {
        holder = holderAccount;
        Agency = agency;
        AccountNumber = accountNumber;
        Balance = balanceAccount;
        Limit = limitAccount;
    }
    public string Info()
    {
        string message = $"The account {Agency}/{AccountNumber} is holded by {holder.Name}\nThere's ${Balance} on balance, and limit of ${Limit}.";
        return message;
    }
}
