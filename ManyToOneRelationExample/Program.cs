using Company;
public class Program
{
    public static void Main()
    {
        //3 employess in same dept
        Employee emp = new Employee()
        {
            EmployeeId = 1, EmployeeName = "ashok", Email = "ashok@gmail.com"
        };
        Employee emp1 = new Employee()
        {
            EmployeeId = 2,
            EmployeeName = "king",
            Email = "ashok1@gmail.com"
        }; Employee emp2 = new Employee()
        {
            EmployeeId = 3,
            EmployeeName = "royal",
            Email = "royal@gmail.com"
        };

        //create object of dept class
        Department department = new Department() { DepartmentID = 12, Dept_Name = "Sales" };
        emp.dept = department;
        emp1.dept = department;
        emp2.dept = department;


        Console.WriteLine("First Employee");
        Console.WriteLine("EmployeeiD:-" + emp.EmployeeId);
        Console.WriteLine("name:-" +emp.EmployeeName);
        Console.WriteLine("email:-" + emp.Email);
        Console.WriteLine("deptid:-" + emp.dept.DepartmentID);
        Console.WriteLine("deptid:-" + emp.dept.Dept_Name);

        Console.WriteLine("second Employee");
        Console.WriteLine("EmployeeiD:-" + emp1.EmployeeId);
        Console.WriteLine("name:-" + emp1.EmployeeName);
        Console.WriteLine("email:-" + emp1.Email);
        Console.WriteLine("deptid:-" + emp1.dept.DepartmentID);
        Console.WriteLine("deptid:-" + emp1.dept.Dept_Name);

        Console.WriteLine("third Employee");
        Console.WriteLine("EmployeeiD:-" + emp2.EmployeeId);
        Console.WriteLine("name:-" + emp2.EmployeeName);
        Console.WriteLine("email:-" + emp2.Email);
        Console.WriteLine("deptid:-" + emp2.dept.DepartmentID);
        Console.WriteLine("deptid:-" + emp2.dept.Dept_Name);


        Console.ReadKey();
    }
}