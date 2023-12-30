using Portal.Models;
namespace DAL;
public static class HRDBManager
{
    public static List<Employee> getAllEmployees()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee { Id = 1, Name = "Varadraj Jagdale" });
        employees.Add(new Employee { Id = 2, Name = "Abhishek Shahane" });
        employees.Add(new Employee { Id = 3, Name = "Arjun Jagtap" });
        employees.Add(new Employee { Id = 4, Name = "Swara Shahapurkar" });
        employees.Add(new Employee { Id = 5, Name = "Pranav Mane" });
        employees.Add(new Employee { Id = 6, Name = "Nilesh Parit" });
        employees.Add(new Employee { Id = 7, Name = "Abhishek Tukan" });
        employees.Add(new Employee { Id = 8, Name = "Omkar Ware" });
        employees.Add(new Employee { Id = 9, Name = "Chinmay Gulhane" });
        return employees;
    }

}