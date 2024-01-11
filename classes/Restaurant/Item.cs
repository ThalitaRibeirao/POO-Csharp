class Item
{
    public string Title { get; set; }
    private decimal price = decimal.Zero;
    public decimal Price { get => price; set=> price = value; }
    public string Description { get; set; }
}