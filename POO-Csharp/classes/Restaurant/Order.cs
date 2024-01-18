class Order
{
    public List<Item> itens = new List<Item>();
    public decimal value = itens.Sum(i => i.price);
    public int table;
}