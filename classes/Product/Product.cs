class Product
{
    public string Name { get; set; }
    public string Brand { get; set; }
    private int stock = 0;
    public int Stock
    {
        get => stock; 
        set => stock = value > 0 ? value : 0; }
   
    private decimal price = (decimal)0;
    public decimal Price
    {
        get => price; 
        set => price = value > 0 ? value : (decimal) 0;
    }
    public string Info => $"Product {Name} ({Brand}): ${Price} ({Stock} available in stock)";
}
