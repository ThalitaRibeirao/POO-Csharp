public class Game
{
    public string Name { get; }
    public string Gender { get; }
    public int YearLaunching { get; }
    private bool available;
    public bool Available { get => available; }


    public Game(string name, string gender, int yearLaunching, bool availableGame = true)
    {
        Name = name;
        Gender = gender;
        YearLaunching = yearLaunching;
        available = availableGame;
    }

    public void ChangeAvailability()
    {
        available = !Available;
    }
}