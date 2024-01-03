class Order
{
    public List<Item> itens = new List<Item>();
    public decimal value;
    public int table;

    public Order()
    {
        value = itens.Sum(i => i.price);
    }
}