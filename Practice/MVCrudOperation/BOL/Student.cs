namespace BOL;

public class Student
{
    public int Id{set;get;}
    public string Fname{set;get;}
    public string Lname{set;get;}
    public string Contact{set;get;}
    public string City{set;get;}

    public Student(){

    }

    public Student(int id,string fname,string lname,string contact,string city)
    {
        this.Id=id;
        this.Fname=fname;
        this.Lname=lname;
        this.Contact=contact;
        this.City=city;

    }

}