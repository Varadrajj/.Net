namespace Portal.Models;

public class Person
{
    public int Id { set; get; }
    public string FirstName { set; get; }
    public string LastName { set; get; }

    public Person()
    {
        this.Id = 0;
        this.FirstName = "Aaa";
        this.LastName = "Bbb";
    }

    public Person(int id, string fname, string lname)
    {
        this.Id = id;
        this.FirstName = fname;
        this.LastName = lname;
    }

}