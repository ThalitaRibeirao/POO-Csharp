using System.Reflection.Metadata.Ecma335;

class Album
{
    public string title;
    public string artist;
    public List<Song> songs = new List<Song>();
    public int duration;  
    public List<Gender> genders = new List<Gender>();
    public List<string> gendersString = new List<string>();

    public Album()
    {
        duration = songs.Sum(s => s.Duration);
        foreach(Song s in songs)
        {
            foreach (Gender g in s.genders)
            {
                if (!genders.Contains(g))
                {
                    genders.Add(g);
                }
            }
        }

        genders.ForEach(g => gendersString.Add(g.title));
    }

    public void AddNewSong(Song song)
    {
        songs.Add(song);
        duration += song.Duration;
        foreach (Gender g in song.genders)
        {
            if (!genders.Contains(g))
            {
                genders.Add(g);
                gendersString.Add(g.title);
            }
        }
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
