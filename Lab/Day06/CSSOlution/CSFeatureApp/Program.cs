using library;
using HR;

Books shelf = new Books();
string MovieTitle = shelf[3];
Console.WriteLine(MovieTitle);
shelf[3] = "Sapian";
MovieTitle = shelf[3];
Console.WriteLine(MovieTitle);

// Employee emp = new Employee();
// emp.CalculateSalary();

// SalesEmployee salesEmp = new SalesEmployee();
// salesEmp.CalculateSalary();

// Employee e3 = salesEmp;
// e3.CalculateSalary();