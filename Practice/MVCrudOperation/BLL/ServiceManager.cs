using BOL;
using DAL;
namespace BLL;

public class ServiceManager
{
    public List<Student> GetAllStudents()
    {
        List<Student> students=new List<Student>();
        students=DBManager.GetAllStudents();
        return students;
    }

    public Student Insert(Student s)
    {
        Student student=new Student();
        DBManager.Insert(s);
        return student;
    } 

    public void Delete(int id)
    {
        DBManager.Delete(id);
    }

    public Student Update(Student s)
    {
        DBManager.Update(s);
        return s;
    }

}

