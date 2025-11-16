using System;

class Program
{
    static void Main(string[] args)
    {
        // Create first Employee object
        Employee emp1 = new Employee()
        {
            Id = 1,
            FirstName = "Nasim",
            LastName = "Misrabi"
        };

        // Create second Employee object
        Employee emp2 = new Employee()
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe"
        };

        // Compare using overloaded == operator
        Console.WriteLine("Comparing Employees...");
        Console.WriteLine($"Are the two employees equal? {emp1 == emp2}");

        // Compare using overloaded != operator
        Console.WriteLine($"Are the two employees different? {emp1 != emp2}");

        Console.ReadLine(); // Pause so user can read results
    }
}
