

using StudentInfo;
using TeacherInfo;

namespace OOPDay1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        Car myCar=new Car();
        myCar.Model="Toyota";//. Operator to access states and behaviors of class 
        myCar.Color="Red";
        myCar.Gearno="4";
        Car.UseBreak();
        myCar.LicenceNo="YGN-303";
        myCar.StartEngine();
        myCar.PlayHorn(3);
        myCar.StopEngine();
        Console.WriteLine(myCar);
        
        Car yourCar=new Car(); 
        yourCar.Model="Honda";
        yourCar.Color="Blue";
        yourCar.Gearno="5";
        yourCar.LicenceNo="YGN-304";
        yourCar.StartEngine();
        yourCar.PlayHorn(2);
        yourCar.StopEngine();
        Console.WriteLine(yourCar);
        Car.UseBreak();
        Console.WriteLine("Show the result for static usage");
        Utility.ApplicationUser();
        Utility.PrintTime();
        Utility.Today();
        Console.WriteLine(Utility.WeekDays);
        Console.WriteLine(1);
        Console.WriteLine(true);

        Teacher teacher=new Teacher();
        teacher.Name="U Ba";
        teacher.Subject="Math";
        Console.WriteLine(teacher);
        Console.WriteLine(teacher.sayHello());
        Teacher.ShowTeacherInfo();

        Student student=new Student();
        Student.ShowStudentInfo();
    }
}
