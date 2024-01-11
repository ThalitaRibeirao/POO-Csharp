class Song
{
    public Song(string titleSong, Band artistSong)
    {
        title = titleSong;
        artist = artistSong;
    }

    private string title;
    public string Title { get => title; }
    private Band artist;
    public Band Artist { get => artist; }
    public Album Album { get; set; }
    private int duration = 0;
    public int Duration { 
        get => duration;
        set => duration = (value > 0) ? value : 0; 
    }
    public bool Available { get; set; }
    public List<Gender> genders = new List<Gender>();

    // Only-read propertie (lambda function)
    public string Description => $"The song {Title} belongs to {Artist.Name}";

    public void ShowInfo(bool shortInfo=false)
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Artist/Band: {Artist.Name}");
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