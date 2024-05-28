using System;

namespace InterfaceDemo
{
    // Define an interface IQuittable
    public interface IQuittable
    {
        // Define a void method Quit in the interface
        void Quit();
    }

    // Define the Employee class that implements the IQuittable interface
    class Employee : IQuittable
    {
        // Implementation of the Quit method from IQuittable
        public void Quit()
        {
            // Print a message when the Quit method is called
            Console.WriteLine("Employee has quit the job!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type IQuittable using polymorphism
            IQuittable quittableEmployee = new Employee();

            // Call the Quit method on the object
            quittableEmployee.Quit();
        }
    }
}
