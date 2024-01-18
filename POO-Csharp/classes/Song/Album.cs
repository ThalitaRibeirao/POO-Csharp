class Album
{
    public string title;
    public string artist;
    public List<Song> songs = new List<Song>();
    public int duration = songs.Sum(s => s.Duration); 
    public List<Gender> genders = new List<Gender>();
    //songs.foreach(s => if (!s.gender in genders) genders.Add(s.gender));
 

    public void AddNewSong(Song song)
    {
        songs.Add(song);
        duration += song.Duration;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Album '{title}, made by {artist}'");
        Console.WriteLine($"Genders: {genders.ToString()}");

        for (int i = 0; i < songs.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {songs[i].Title}");
        }
    }
}
