class Table
{
    public bool occupied = false;
    public int id;
    public List<Order> orders = new List<Order>();
    public decimal value;

    public Table()
    {
        value = orders.Sum(o => o.value);
    }
}