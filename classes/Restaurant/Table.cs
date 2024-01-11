class Table
{
    public bool Occupied { get; set; }
    private int id;
    public int Id { get => id; }
    public List<Order> orders = new List<Order>();
    public decimal Value;

    public Table()
    {
        Occupied = false;
        Value = orders.Sum(o => o.Value);
    }
}