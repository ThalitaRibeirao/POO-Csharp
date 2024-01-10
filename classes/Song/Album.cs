using System.Reflection.Metadata.Ecma335;

class Album
{
    public string title;
    public string artist;
    public Band band = new Band();
    public List<Song> songs = new List<Song>();
    public int duration;  
    public List<Gender> genders = new List<Gender>();
    public List<string> gendersString = new List<string>();
    
    
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
                gendersString.Add(gender.title);
            }
        }
    }
    
    public void AddNewSong(Song song)
    {
        songs.Add(song);
        duration += song.Duration;
        AddNewGender(song);
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Album '{title}, made by {artist}'");
        Console.Write($"Genders: {string.Join(", ", gendersString)}");
        
        Console.WriteLine($"\nDuration: {duration}s");
        for (int i = 0; i < songs.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {songs[i].Title}");
        }
    }
}
