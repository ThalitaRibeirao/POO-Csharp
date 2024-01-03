class Banking
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Amount { get; set; }
    public string Password { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Holder's name: {Name}");
        Console.WriteLine($"Amount available: ${Amount}");
        Console.ReadKey();
    }
}
