public class Song
{
    public Song(string title, Band artist, int durationSong = 0, bool available = true)
    {
        Title = title;
        Artist = artist;
        Available = available;
        Duration = durationSong;
    }


    public string Title { get; }
    public Band Artist { get ; }
    public Album Album { get; set; }
    
    private int duration;
    public int Duration { 
        get => duration;
        set => duration = (value > 0) ? value : duration; 
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