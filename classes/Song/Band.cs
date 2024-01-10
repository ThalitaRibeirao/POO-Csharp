class Band
{
    public string Name { get; set; }
    public List<string> artists;
    public List<Album> albuns = new List<Album>();
    public List<Gender> genders = new List<Gender>();

    public Band()
    {
        foreach (Album album in albuns)
        {
            foreach (Gender gender in album.genders)
            {
                if (!genders.Contains(gender))
                {
                    genders.Add(gender);
                }
            }
        }
    }

    public void AddAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"Showing discography of {Name}");

        foreach (Album album in albuns)
        {

        }
    }
}