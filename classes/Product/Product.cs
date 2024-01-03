class Product
{
    public string name;
    public string brand;
    private int stock = 0;
    public int Stock { get { return stock; } set { stock = value > 0 ? value : 0; } }
    private decimal price = (decimal) 0;
    public decimal Price{ get { return price; } set {  price = value > 0 ? value : (decimal) 0; } }
    public string Info => $"Product {name} ({brand}): ${price} ({stock} available in stock)";
}
