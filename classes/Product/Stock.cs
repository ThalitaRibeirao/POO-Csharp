class Stock
{
    public List<Product> products = new List<Product>();

    public void AddNewProduct(Product newProduct)
    {
        products.Add(newProduct);
    }

    public void ShowProducts()
    {
        foreach(Product p in products)
        {
            Console.WriteLine(p.Info);
        }
    }
}