class Car
{
    public string Producer { get; set; }
    public string Model { get; set; }
    private int year;
    public int Year {
        get => year;
        set => year = (value >= 1960 && value <= 2023) ? value : -1;
    }
    
    public string Description => $"The car {Model} ({Year}) is produced by {Producer}";
    public int speed = 0;

    
    public void SpeedUp()
    {
        Console.WriteLine("Speeding Up! Move away");
        speed++;
    }

    public void Break()
    {
        Console.WriteLine("Breaking! Hold your seat belt");
        speed--;
    }

    public void Honk()
    {
        Console.WriteLine("* Beep Beep Beep *");
    }

    public void Start()
    {
        int option;
        while (true)
        {
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 0:
                    SpeedUp();
                    break;
                case 1:
                    Break();
                    break;
                case 2:
                    Honk();
                    break;
                default:
                    return;
            }
        }
    }
}