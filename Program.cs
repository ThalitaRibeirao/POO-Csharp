// especify problem
new Problems().GamingProblem();
Console.ReadKey();

class Problems
{
    public void BankingProblem()
    {
        Banking banking = new Banking()
        {
            Name = "John Affron", 
            Amount = (decimal)100
        };

        banking.ShowInfo();
    }

    public void CarProblem()
    {
        Car car = new Car()
        {
            Year = 1940
        };

        Console.WriteLine(car.Year);
        Console.ReadKey();
    }

    public void SongProblem()
    {
        Band band = new Band("Beach House");
        Album album = new Album("Depression Cherry", band);
        Song song = new Song("Space Song", band)
        {
            Album = album,
            Duration = 320
        }; 


        // Working with optional values
        song.ShowInfo(true);

        // Working with properties
        Console.WriteLine(song.Description);
        Console.ReadKey();
    }

    public void ProductProblem()
    {
        Product product = new Product();
        product.Name = "Mi Band 8";
        product.Brand = "Xiaomi";
        product.Price = (decimal)284.90;
        product.Stock = 5000;

        Console.WriteLine(product.Info);
    }

    public void AlbumProblem()
    {
        // Creating the band
        Band calypso = new Band("Banda Calypso");

        // Creating a new Album
        List<string> songsTitle = new List<string> { "A Lua Me Traiu", "Chá de Maracujá", "Acelerou", "Cavalo Manco", "Dez a Zero" };
        Album album = new Album("Ao Vivo em Recife", calypso);

        List<Gender> genders = new List<Gender>();
        genders.Add(new Gender("Pop"));
        genders.Add(new Gender("Forró"));

        foreach (string title in songsTitle)
        {
            Song newSong = new Song(title, calypso)
            {
                Album = album,
                Duration = 60,
                genders = genders
            };

            album.AddNewSong(newSong);
        }

        calypso.AddAlbum(album);
        // album.ShowInfo();
        calypso.ShowDiscography();
    }

    public void AccountProblem()
    {
        Holder holder = new Holder("Thailta", "1234", "Rua avenida da Alameda");
        Account account = new Account(holder, "12345", "12345", (decimal)1000, (decimal)5000);
        Console.WriteLine(account.Info());
    }

    public void StockProblem()
    {
        Stock stock = new Stock();
        List<string> products = new List<string> {"Mi Band", "Poco Mini", "Redmi Light"};

        foreach (string p in products)
        {
            Product product = new Product()
            {
                Name = p,
                Brand = "Xiaomi"
            };

            stock.AddNewProduct(product);
        }
        stock.ShowProducts();
    }

    public void GamingProblem()
    {
        GameCatalogue catalogue = new GameCatalogue();

        //catalogue.AddGame(new Game("Dead By Daylight", "Thriller", 2016));
        //catalogue.AddGame(new Game("Overwatch 2", "FPS", 2022
        //catalogue.AddGame(new Game("Poison Craft", "Indie", 2021));

        catalogue.ShowGames();
    }
}
