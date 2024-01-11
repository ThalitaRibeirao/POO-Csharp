using System.Dynamic;

class Account
{
    public Holder holder = new Holder();
    public string Agency { get; set; }
    public string AccountNumber { get; set; }
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


    public string Info()
    {
        string message = $"The account {Agency}/{AccountNumber} is holded by {holder.Name}\nThere's ${Balance} on balance, and limit of ${Limit}.";
        return message;
    }
}
