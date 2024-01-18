namespace library;
public class Books
{
    private string[] title;
    public Books()
    {
        title = new string[5];

        title[0] = "Avengers";
        title[1] = "Thor";
        title[2] = "Green Lantern";
        title[3] = "Spider-Man";
        title[4] = "DeadPool";
    }

    public string this[int index]
    {
        get { return title[index]; }
        set { title[index] = value; }
    }
}