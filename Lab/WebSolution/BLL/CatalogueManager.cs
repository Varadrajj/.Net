namespace BLL;
using BOL;
using DAL.Connected;

public class CatalogueManager
{
    public List<Student> getStudents()
    {
        List<Student> allStudents = new List<Student>();
        allStudents = DBManager.getAllStudents;
        return allStudents;

    }

}