using System;

namespace EmployeeComparison
{
    // Define the Employee class
    class Employee
    {
        // Properties for Id, FirstName, and LastName
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the "==" operator to compare two Employee objects based on their Id property
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if the Ids are equal, return true if they are
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;  // If both are null, they are considered equal

            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;  // If one is null and the other is not, they are not equal

            return emp1.Id == emp2.Id;  // Compare the Id properties
        }

        // Overload the "!=" operator to check inequality based on Id
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Use the same logic as ==, but return the opposite result
            return !(emp1 == emp2);
        }

        // Override the Equals method to compare Employee objects correctly
        public override bool Equals(object obj)
        {
            if (obj is Employee otherEmployee)
            {
                return this.Id == otherEmployee.Id;
            }
            return false;
        }

        // Override the GetHashCode method to ensure consistency with the Equals method
        public override int GetHashCode()
        {
            return Id.GetHashCode();  // Use Id as the basis for the hash code
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects with different Ids
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

            // Display employee details for reference
            Console.WriteLine("Employee 1: " + employee1.FirstName + " " + employee1.LastName + ", ID: " + employee1.Id);
            Console.WriteLine("Employee 2: " + employee2.FirstName + " " + employee2.LastName + ", ID: " + employee2.Id);

            // Compare the two Employee objects using the overloaded "==" operator
            if (employee1 == employee2)
            {
                Console.WriteLine("Employee 1 and Employee 2 are the same.");
            }
            else
            {
                Console.WriteLine("Employee 1 and Employee 2 are not the same.");
            }

            // Compare the two Employee objects using the overloaded "!=" operator
            if (employee1 != employee2)
            {
                Console.WriteLine("Employee 1 and Employee 2 are different.");
            }
            else
            {
                Console.WriteLine("Employee 1 and Employee 2 are the same.");
            }

            // Pause the console to see the output
            Console.ReadLine();
        }
    }
}

