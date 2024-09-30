// InterfaceExample.cs
using System;

namespace OOPs.Interfaces
{
    // Step 1: Define an interface
    public interface IVehicle
    {
        void Start();
        void Stop();
        void Drive(int speed);
        void DisplayInfo();
    }

    // Step 2: Implement the interface in Car class
    public class Car : IVehicle
    {
        private string _make;
        private string _model;
        private int _year;
        private int _speed;

        // Constructor for the Car class
        public Car(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
            _speed = 0;  // Initial speed
        }

        // Implement the Start method
        public void Start()
        {
            Console.WriteLine($"{_make} {_model} is starting.");
        }

        // Implement the Stop method
        public void Stop()
        {
            Console.WriteLine($"{_make} {_model} has stopped.");
        }

        // Implement the Drive method
        public void Drive(int speed)
        {
            _speed = speed;
            Console.WriteLine($"{_make} {_model} is driving at {_speed} km/h.");
        }

        // Implement the DisplayInfo method
        public void DisplayInfo()
        {
            Console.WriteLine($"Car Info: {_make} {_model}, Year: {_year}, Speed: {_speed} km/h");
        }
    }

    // Step 3: Implement the interface in Truck class
    public class Truck : IVehicle
    {
        private string _make;
        private string _model;
        private int _year;
        private int _cargoCapacity;

        // Constructor for the Truck class
        public Truck(string make, string model, int year, int cargoCapacity)
        {
            _make = make;
            _model = model;
            _year = year;
            _cargoCapacity = cargoCapacity;
        }

        // Implement the Start method
        public void Start()
        {
            Console.WriteLine($"{_make} {_model} is starting.");
        }

        // Implement the Stop method
        public void Stop()
        {
            Console.WriteLine($"{_make} {_model} has stopped.");
        }

        // Implement the Drive method
        public void Drive(int speed)
        {
            Console.WriteLine($"{_make} {_model} is driving at {speed} km/h with cargo capacity of {_cargoCapacity} kg.");
        }

        // Implement the DisplayInfo method
        public void DisplayInfo()
        {
            Console.WriteLine($"Truck Info: {_make} {_model}, Year: {_year}, Cargo Capacity: {_cargoCapacity} kg");
        }
    }

    // Step 4: Demonstrating interface implementation
    public class InterfaceExample
    {
        public static void RunExample()
        {
            Console.WriteLine("\n--- Interface Example ---");

            // Create Car object
            IVehicle myCar = new Car("Toyota", "Camry", 2020);
            myCar.Start();
            myCar.Drive(100);
            myCar.Stop();
            myCar.DisplayInfo();

            Console.WriteLine();  // Line break

            // Create Truck object
            IVehicle myTruck = new Truck("Ford", "F-150", 2019, 2000);
            myTruck.Start();
            myTruck.Drive(80);
            myTruck.Stop();
            myTruck.DisplayInfo();
        }
    }
}
