using System.Net.Http.Headers;

public class GameCatalogue
{
    private List<Game> games = new List<Game>();
    public List<Game> Games
    {
        get => games;
    }

    public void AddGame(Game game)
    {
        games.Add(game);
    }

    public void RemoveGame(string name)
    {
        for (int i = 0; i < games.Count; i++)
        {
            if (games[i].Name == name)
            {
                games.RemoveAt(i);
                return;
            }
        }

        Console.WriteLine($"Can't find the game {name}, please check.");
    }

    public List<Game> getGamesAvailable()
    {
        List<Game> gamesAvailable = new List<Game>(games);
        gamesAvailable.Where(g => g.Available == true);
        return gamesAvailable;
    }

    public bool isEmpty()
    {
        List<Game> gamesAvailable = getGamesAvailable();
        return gamesAvailable.Count == 0;
    }

    public void ShowGames()
    {
        
        if (isEmpty())
        {
            Console.WriteLine("There's no available game in the moment.");
        }
        else
        {

            Console.WriteLine("Available games:");

            foreach (Game game in getGamesAvailable())
            {
                Console.WriteLine($"-> {game.Name} ({game.YearLaunching}) ");
            }
        }
    }
}