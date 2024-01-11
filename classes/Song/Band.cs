class Band
{
    public string Name { get; set; }
    public List<string> artists = new List<string>();
    public List<Album> albuns = new List<Album>();
    public List<Gender> genders = new List<Gender>();

    public void AddAlbum(Album album)
    {
        albuns.Add(album);
        AddGender(album);
    }

    public void AddGender(Album album)
    {
        foreach (Gender gender in album.genders)
        {
            if (!genders.Contains(gender))
            {
                genders.Add(gender);
            }
        }
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"Showing discography of {Name}");

        foreach (Album album in albuns)
        {
            Console.WriteLine(album.Title);
            Console.WriteLine(album.Artist);
            Console.WriteLine(album.GetAllGenders());
        }
    }
}