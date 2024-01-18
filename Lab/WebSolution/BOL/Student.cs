namespace BOL;

public class Student
{
    public int Id { set; get; }
    public string FirstName { set; get; }
    public string LastName { set; get; }
    public string EmailId { set; get; }

    public Student()
    {
        this.Id = 1;
        this.FirstName = "Varadraj";
        this.LastName = "Jagdale";
        this.EmailId = "raj@gmail.com";


    }

    public Student(int id, string fname, string lname, string emailid)
    {
        this.Id = id;
        this.FirstName = fname;
        this.LastName = lname;
        this.EmailId = emailid;
    }

}
