class Order
{
    public List<Item> itens = new List<Item>();
    public decimal Value { get; set; }
    public int TableNumber { get; set; }

    public Order()
    {
        Value = itens.Sum(i => i.Price);
    }

    public void addItem(Item item)
    {
        itens.Add(item);
        Value += item.Price;
    }
}