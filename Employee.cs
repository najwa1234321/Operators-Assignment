using System;

// Employee class with Id, FirstName, LastName
public class Employee
{
    // Unique employee identifier
    public int Id { get; set; }

    // Employee first name
    public string FirstName { get; set; }

    // Employee last name
    public string LastName { get; set; }

    // Overload == operator to compare Employees by Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // If both are null → equal
        if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
            return true;

        // If one is null → not equal
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            return false;

        // Compare Ids
        return emp1.Id == emp2.Id;
    }

    // Overload != operator (must be paired with ==)
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }

    // Override Equals() to avoid warnings
    public override bool Equals(object obj)
    {
        if (obj is Employee other)
            return this.Id == other.Id;

        return false;
    }

    // Override GetHashCode() for consistency
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
