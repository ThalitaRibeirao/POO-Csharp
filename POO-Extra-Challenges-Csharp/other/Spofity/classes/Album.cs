public class Album
{
    public Album (string titleAlbum, Band artistAlbum)
    {
        Artist = artistAlbum;
        Title = titleAlbum;
        duration = songs.Sum(song => song.Duration);
        foreach (Song song in songs) AddNewGender(song);
    }


    // Variables
    public string Title { get; }
    public Band Artist { get; }
    public List<Song> songs = new List<Song>();
    
    private int duration = 0;
    public int Duration { get => duration; }
    public List<Gender> genders = new List<Gender>();
    public List<string> gendersString = new List<string>();


    public void AddNewGender(Song song)
    {
        foreach (Gender gender in song.genders)
        {
            // Checking if gender hasn't been added
            if (!genders.Contains(gender))
            {
                genders.Add(gender);
                gendersString.Add(gender.Title);
            }
        }
    }
    

    public void AddNewSong(Song song)
    {
        if (song.Artist != Artist)
        {
            Console.WriteLine("The song's Artist is different, please check");
        }
        else
        {
            songs.Add(song);
            duration += song.Duration;
            AddNewGender(song);
        }
    }


    public string GetAllGenders()
    {
        return string.Join(", ", gendersString);
    }


    public void ShowInfo()
    {
        Console.WriteLine($"Album '{Title}', made by {Artist.Name}");
        Console.Write($"Genders: {GetAllGenders()}");
        
        Console.WriteLine($"\nDuration: {Duration}s");
        for (int i = 0; i < songs.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {songs[i].Title}");
        }
    }
}
