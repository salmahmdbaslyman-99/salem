class Person
{
    public string Name;
    public string Email;

    public Person(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public void DisplayBasicInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Email: " + Email);
    }
}

class Student : Person
{
    public int StudentId;
    public double GPA;

    public Student(string name, string email, int studentId, double gpa)
        : base(name, email)
    {
        StudentId = studentId;
        GPA = gpa;
    }
}

class Employee : Person
{
    public int EmployeeId;
    public double Salary;

    public Employee(string name, string email, int employeeId, double salary)
        : base(name, email)
    {
        EmployeeId = employeeId;
        Salary = salary;
    }
}

class Teacher : Employee
{
    public string CourseName;

    public Teacher(string name, string email, int employeeId, double salary, string courseName)
        : base(name, email, employeeId, salary)
    {
        CourseName = courseName;
    }

    public void Teach()
    {
        Console.WriteLine(Name + " is teaching " + CourseName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Salem", "salem@gmail.com", 101, 3.5);


        Teacher teacher = new Teacher("Ahmed", "ahmed@gmail.com", 202, 5000, "C#");



        student.DisplayBasicInfo();
        Console.WriteLine("Student ID: " + student.StudentId);
        Console.WriteLine("GPA: " + student.GPA);

        Console.WriteLine("----------------");

        teacher.DisplayBasicInfo();
        Console.WriteLine("Employee ID: " + teacher.EmployeeId);
        Console.WriteLine("Salary: " + teacher.Salary);

        teacher.Teach();
    }
}
