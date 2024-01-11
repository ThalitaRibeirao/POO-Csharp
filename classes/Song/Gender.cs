class Gender
{
    public string Title { get; set; }

    public Gender(string genderTitle = "")
    {
        if (genderTitle != "")
        {
            Title = genderTitle;
        }
    }
}