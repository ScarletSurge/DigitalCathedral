// See https://aka.ms/new-console-template for more information

using DigitalCathedral.Task1;

try
{
    Student s1 = new Student("", "", "", "", "", 3);
    Student s2 = new Student("", "", "", "", "", 3);
    Console.WriteLine(s1.Equals(s2));
    Student st = new Student("Ivanov", "Ivan", "Ivanovich", "M1O-301B-21", "1234-123-12", 3);

    Console.WriteLine("No exceptions were thrown");
}
catch (ArgumentNullException ex)
{
    // 
    Console.WriteLine(ex.Message);
}
catch (ArgumentException ex)
{
    // 
    Console.WriteLine(ex.Message);
}

Console.WriteLine("after try/catch...");