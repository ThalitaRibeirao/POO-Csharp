class Account
{
    public Holder holder = new Holder();
    public string agency;
    public string account;
    public decimal balance = (decimal) 0;
    public decimal limit = (decimal) 0;

    public string Info()
    {
        string message = $"The account {agency}/{account} is holded by {holder.name}\nThere's ${balance} on balance, and limit of ${limit}.";
        return message;
    }
}
