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
        product.Name = "Mi Band 8";
        product.Brand = "Xiaomi";
        product.Price = (decimal)284.90;
        product.Stock = 5000;

        Console.WriteLine(product.Info);
    }

    public void AlbumProblem()
    {
        // Creating the band
        Band calypso = new Band();
        calypso.Name = "Banda Calypso";
        calypso.artists.Add("Joelma");
        calypso.artists.Add("Chimbinha");

        // Creating a new Album
        List<string> songsTitle = new List<string> { "A Lua Me Traiu", "Chá de Maracujá", "Acelerou", "Cavalo Manco", "Dez a Zero" };
        Album album = new Album();

        album.Title = "Ao Vivo em Recife";
        album.band = calypso;

        List<Gender> genders = new List<Gender>();
        genders.Add(new Gender("Pop"));
        genders.Add(new Gender("Forró"));

        foreach (string title in songsTitle)
        {
            Song newSong = new Song();
            newSong.Title = title;
            newSong.band = album.band;
            newSong.Album = album.Title;
            newSong.Duration = 60;
            newSong.genders = new List<Gender>(genders);
            album.AddNewSong(newSong);
        }

        calypso.AddAlbum(album);
        album.ShowInfo();
    }

    public void AccountProblem()
    {
        Account account = new Account();
        account.holder.Name = "Thalita";
        account.AccountNumber = "XXX";
        account.Agency = "123456";

        Console.WriteLine(account.Info());
    }

    public void StockProblem()
    {
        Stock stock = new Stock();
        List<string> products = new List<string> {"Mi Band", "Poco Mini", "Redmi Light"};
        foreach (string p in products)
        {
            Product product = new Product();
            product.Name = p;
            product.Brand = "Xiaomi";
            stock.AddNewProduct(product);
        }
        stock.ShowProducts();
    }
}
