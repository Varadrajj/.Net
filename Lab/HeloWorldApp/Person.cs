namespace HR;

public class Person{

    private int id;
    private string firstname;
    //private string lastname;

    public void SetFirstName(string f){
        this.firstname = f;
    }
    public string GetFirstName(){
        return this.firstname;
    }

    public string lastName{
        set; get;
    }

    public Person(){
        this.id = 99;
        this.firstname = "Abhi";
        this.lastName = "Shahane";
    }

    public Person(int id, string fname, string lname){
        this.id = id;
        this.firstname = fname;
        this.lastName = lname;
    }

    ~ Person(){

    }

    public override string  ToString(){
        return this.firstname + " " + this.lastName;
    }

}