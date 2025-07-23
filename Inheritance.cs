//  Q1. Student and Result (Single Inheritance)

using System;

class Student
{
    public int RollNo;
    public string Name;
    public int Age;

    public void GetStudentDetails()
    {
        Console.Write("Enter Roll No: ");
        RollNo = int.Parse(Console.ReadLine());
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();
        Console.Write("Enter Age: ");
        Age = int.Parse(Console.ReadLine());
    }

    public void DisplayStudent()
    {
        Console.WriteLine($"Roll No: {RollNo}, Name: {Name}, Age: {Age}");
    }
}

class Result : Student
{
    public int Marks1, Marks2, Marks3;

    public void GetMarks()
    {
        Console.Write("Enter Marks1: ");
        Marks1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Marks2: ");
        Marks2 = int.Parse(Console.ReadLine());
        Console.Write("Enter Marks3: ");
        Marks3 = int.Parse(Console.ReadLine());
    }

    public void DisplayResult()
    {
        int total = Marks1 + Marks2 + Marks3;
        float avg = total / 3.0f;
        Console.WriteLine($"Total Marks: {total}, Average: {avg:F2}");
    }
}

class Program
{
    static void Main()
    {
        Result r = new Result();
        r.GetStudentDetails();
        r.GetMarks();
        Console.WriteLine("\n--- Student Details ---");
        r.DisplayStudent();
        r.DisplayResult();
    }
}


//Q2. Shape and Rectangle (Method Overriding)

using System;

class Shape
{
    public virtual void Area()
    {
        Console.WriteLine("Area of shape is undefined.");
    }
}

class Rectangle : Shape
{
    public override void Area()
    {
        Console.Write("Enter Length: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Breadth: ");
        double breadth = Convert.ToDouble(Console.ReadLine());
        double area = length * breadth;
        Console.WriteLine($"Area of Rectangle: {area}");
    }
}

class Program
{
    static void Main()
    {
        Shape s;
        s = new Rectangle(); // base class reference, derived class object
        s.Area();
    }
}

//Q3. Person → Employee → Manager (Multilevel Inheritance)

using System;

class Person
{
    public string Name;
    public int Age;

    public void GetPerson()
    {
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();
        Console.Write("Enter Age: ");
        Age = int.Parse(Console.ReadLine());
    }
}

class Employee : Person
{
    public int EmpID;
    public double Salary;

    public void GetEmployee()
    {
        Console.Write("Enter Employee ID: ");
        EmpID = int.Parse(Console.ReadLine());
        Console.Write("Enter Salary: ");
        Salary = double.Parse(Console.ReadLine());
    }
}

class Manager : Employee
{
    public string Department;

    public void GetManager()
    {
        Console.Write("Enter Department: ");
        Department = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine("\n--- Manager Details ---");
        Console.WriteLine($"Name: {Name}, Age: {Age}");
        Console.WriteLine($"EmpID: {EmpID}, Salary: {Salary}");
        Console.WriteLine($"Department: {Department}");
    }
}

class Program
{
    static void Main()
    {
        Manager m = new Manager();
        m.GetPerson();
        m.GetEmployee();
        m.GetManager();
        m.Display();
    }
}

//Q4. Vehicle → Car and Bike (Hierarchical Inheritance)

using System;

class Vehicle
{
    public string Brand;
    public int Speed;

    public void GetVehicle()
    {
        Console.Write("Enter Brand: ");
        Brand = Console.ReadLine();
        Console.Write("Enter Speed: ");
        Speed = int.Parse(Console.ReadLine());
    }

    public void DisplayVehicle()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
    }
}

class Car : Vehicle
{
    public string FuelType;

    public void GetCar()
    {
        GetVehicle();
        Console.Write("Enter Fuel Type (Petrol/Diesel): ");
        FuelType = Console.ReadLine();
    }

    public void DisplayCar()
    {
        Console.WriteLine("\n--- Car Details ---");
        DisplayVehicle();
        Console.WriteLine($"Fuel Type: {FuelType}");
    }
}

class Bike : Vehicle
{
    public int Mileage;

    public void GetBike()
    {
        GetVehicle();
        Console.Write("Enter Mileage (km/l): ");
        Mileage = int.Parse(Console.ReadLine());
    }

    public void DisplayBike()
    {
        Console.WriteLine("\n--- Bike Details ---");
        DisplayVehicle();
        Console.WriteLine($"Mileage: {Mileage} km/l");
    }
}

class Program
{
    static void Main()
    {
        Car c = new Car();
        c.GetCar();
        c.DisplayCar();

        Bike b = new Bike();
        b.GetBike();
        b.DisplayBike();
    }
}




using System;
namespace TestDemo
{
    class Person
    {
        string Name;
        int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void displayPerson()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
        }
    }

    class Employee : Person
    {
        int EmpId;
        double Salary;

        public Employee(string name, int age, int empId, double salary) : base(name, age)
        {
            EmpId = empId;
            Salary = salary;
        }

        public void dispayEmployee()
        {
            displayPerson();
            Console.WriteLine("Employee Id : " + EmpId);
            Console.WriteLine("Employee Salary : " + Salary);
        }
    }
    public class InheritanceDemo
    {
        public static void Main()
        {
            Console.Write("Enter the Name : ");
            string name = Console.ReadLine();

            Console.Write("Enter the age : ");
            int age = int.Parse(Console.ReadLine());


            Console.Write("Enter the EmployeeId : ");
            int empId = int.Parse(Console.ReadLine());

            Console.Write("Enter the Salary of Employee : ");
            double sal = double.Parse(Console.ReadLine());


            Employee emp = new Employee(name, age, empId, sal);
            emp.dispayEmployee();
        }
    }
}



