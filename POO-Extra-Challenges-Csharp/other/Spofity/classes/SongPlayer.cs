using System.Dynamic;

public class SongPlayer
{
    public List<Song> Queue = new List<Song>();
    public List<Song> History = new List<Song>();
    private Song currentSong;
    public Song CurrentSong { get => currentSong; }
    
    private int currentSecond;
    public int CurrentSecond { get => currentSecond ; }

    private bool isPlaying;
    public bool IsPlaying { get => isPlaying; }
    
    private int volume;
    public int Volume { get => volume; }

    public bool repeatMode;
    public bool RepeatMode { get => repeatMode; }

    public SongPlayer()
    {
        isPlaying = false;
        repeatMode = false;
        currentSecond = 0;
        volume = 100;
    }
    public void PlaySong(Song song)
    {
        currentSong = song;
        currentSecond = 0;
        isPlaying = true;
    }

    public void AddToQueue(Song song)
    {
        Queue.Add(song);
    }

    public void NextSong()
    {
        if (Queue.Count > 0)
        {
            Song song = Queue[0];
            PlaySong(song);
            RemoveSong(song);
        }
    }

    public int SearchSong(string songTitle)
    {
        for (int i = 0; i < Queue.Count; i++)
        {
            Song song = Queue[i];
            if (song.Title == songTitle)
            {
                return i;
            }
        }
        Console.WriteLine($"Can't find the song {songTitle} in queue");
        return -1;
    }

    public void RemoveSong(Song song)
    {
        int index = SearchSong(song.Title);
        Queue.RemoveAt(index);
    }

    public void Pause()
    {
        isPlaying = false;
    }

    public void ClearQueue()
    {
        Queue = new List<Song>();
    }

    public void TurnUpVolume()
    {
        if (volume < 100)
        {
            volume++;
        }
    }

    public void TurnDownVolume()
    {
        if (volume > 0)
        {
            volume--;
        }
    }

    public void SilentMode()
    {
        volume = 0;
    }

}