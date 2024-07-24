using CustomizeException.Model;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the age");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine(Person.AgeCheck(age));
    }
}
