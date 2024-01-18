Problems problems = new Problems();
// especify problem
problems.AlbumProblem();
Console.ReadKey();

class Problems
{
    public void BankingProblem()
    {
        Banking banking = new Banking();
        banking.Name = "John Affron";
        banking.Amount = (decimal)100.0;

        banking.ShowInfo();
    }

    public void CarProblem()
    {
        Car car = new Car();

        car.Year = 1940;

        Console.WriteLine(car.Year);
        Console.ReadKey();
    }

    public void SongProblem()
    {
        Song song = new Song();

        song.Title = "Space Song";
        song.Artist = "Beach House";
        song.Album = "Depression Cherry";
        song.Duration = 320;

        // Working with optional values
        song.ShowInfo(true);

        // Working with properties
        Console.WriteLine(song.Description);
        Console.ReadKey();


    }

    public void ProductProblem()
    {
        Product product = new Product();
        product.name = "Mi Band 8";
        product.brand = "Xiaomi";
        product.Price = (decimal)284.90;
        product.Stock = 5000;

        Console.WriteLine(product.Info);
    }

    public void AlbumProblem()
    {
        Album album = new Album();
        List<string> songsTitle = new List<string> { "A Lua Me Traiu", "Chá de Maracujá", "Acelerou", "Cavalo Manco", "Dez a Zero"};

        album.title = "Ao Vivo em Recife";
        album.artist = "Calypso";

        foreach(string title in songsTitle)
        {
            Song newSong = new Song();
            newSong.Title = title;
            newSong.Artist = album.artist;
            newSong.Album = album.title;
            newSong.Duration = 60;
            newSong.Gender = "Rock".
            album.AddNewSong(newSong);
        }
        album.ShowInfo();
    }

    public void AccountProblem()
    {
        Account account = new Account();
        account.holder.name = "Thalita";
        account.account = "XXX";
        account.agency = "123456";

        Console.WriteLine(account.Info());
    }

    public void StockProblem()
    {
        Stock stock = new Stock();
        List<string> products = new List<string> {"Mi Band", "Poco Mini", "Redmi Light"};
        foreach (string p in products)
        {
            Product product = new Product();
            product.name = p;
            product.brand = "Xiaomi";
            stock.AddNewProduct(product);
        }
        stock.ShowProducts();
    }
}
