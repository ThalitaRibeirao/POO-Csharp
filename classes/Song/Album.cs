using System.Reflection.Metadata.Ecma335;

class Album
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public Band band = new Band();
    public List<Song> songs = new List<Song>();
    private int duration { get; set; }

    public int Duration
    {
        get
        {
            return duration;
        }
    }  
    public List<Gender> genders = new List<Gender>();
    public List<string> gendersString = new List<string>();

    public string Owner
    {
        get
        {
            if (Artist == null) return band.Name;
            else return Artist;
        }
    }
    
    public Album()
    {
        duration = songs.Sum(song => song.Duration);
        foreach(Song song in songs) AddNewGender(song);
    }

    // Checking if gender hasn't been added
    public void AddNewGender(Song song)
    {
        foreach (Gender gender in song.genders)
        {
            if (!genders.Contains(gender))
            {
                genders.Add(gender);
                gendersString.Add(gender.Title);
            }
        }
    }
    
    public void AddNewSong(Song song)
    {
        if (song.Artist != Artist || song.band != band)
        {
            Console.WriteLine("The song's owner is different, please check");
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
        Console.WriteLine($"Album '{Title}', made by {Owner}");
        Console.Write($"Genders: {GetAllGenders()}");
        
        Console.WriteLine($"\nDuration: {Duration}s");
        for (int i = 0; i < songs.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {songs[i].Title}");
        }
    }
}
