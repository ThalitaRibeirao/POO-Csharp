using System.Reflection.Metadata.Ecma335;

class Student
{
    public string Name { get; set; }
    private int age;
    public int Age
    {
        get => age; 
        set
        {
            if (value >= 0 && value <= 120)
            {
                age = value;
            }
        }

    }
    public List<float> grades = new List<float>();
}