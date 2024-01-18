using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;


public class Display
{
    private Form SpofityForm;
    private PictureBox PB;
    private Label SongTitle;
    private Label SongArtist;
    private Label SongTime;
    private Button Back;
    private Button Pause;
    private Button Next;
    private TimeBar TimeBar;

    public Display(Form spofityForm, PictureBox pb, Label songTitle, Label songArtist, Label songTime, Button back,
        Button pause, Button next, TimeBar timeBar)
    {
        SpofityForm = spofityForm;
        PB = pb;
        SongTitle = songTitle;
        SongArtist = songArtist;
        SongTime = songTime;
        Back = back;
        Pause = pause;
        Next = next;
        TimeBar = timeBar;
    }
    public void ShowInfo(string songTitle, string songArtist, string imageId, int currentSecond, int totalSeconds)
    {
        SongTitle.Text = songTitle;
        SongArtist.Text = songArtist;
        SongTime.Text = GetFullTime(currentSecond, totalSeconds);
        TimeBar.Show(currentSecond, totalSeconds);
        ShowImage(imageId);
    }

    private void ShowImage(string id)
    {
        string imageFile = $"C:\\Users\\thaly\\Study\\csharp\\POO-Csharp\\POO-Extra-Challenges-Csharp\\Spofity\\images\\{id}.jpg";
        PB.Load(imageFile);
    }

    string GetFullTime(int currentSecond, int totalSeconds)
    {
        string currentSecondString = GetTimeString(currentSecond, totalSeconds > 3600);
        string totalSecondsString = GetTimeString(totalSeconds);
        string fullTime = $"{currentSecondString}/{totalSecondsString}";
        return fullTime;
    }
    private string GetTimeString(int totalSeconds, bool showHours = false)
    {
        int hours = (totalSeconds / 60) / 60;
        int minutes = totalSeconds / 60;
        int seconds = totalSeconds % 60;

        if (hours > 0 || showHours) return $"{hours}:{minutes}:{seconds}";
        else return $"{minutes}:{seconds}";
    }
}