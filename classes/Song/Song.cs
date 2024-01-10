class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public Band band = new Band();
    public string Album { get; set; }
    private int duration = 0;
    public int Duration { 
        get => duration;
        set => duration = (value > 0) ? value : 0; 
    }
    public bool Available { get; set; }
    public List<Gender> genders = new List<Gender>();

    // Only-read propertie (lambda function)
    public string Description => $"The song {Title} belongs to {Artist}";

    public void ShowInfo(bool shortInfo=false)
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Artist: {Artist}");
        if (!shortInfo)
        {
            Console.WriteLine($"Album: {Album}");
            Console.WriteLine($"Duration: {Duration}s");
            if (Available)
            {
                Console.Write("This song is available in your current plan");
            }
            else
            {
                Console.Write("This song is NOT available in your current plan");
            }
        }

        Console.ReadKey();
    }
}