using System;

namespace OOPs
{
    // 1. Base class (Parent class)
    public class Vehicle
    {
        // Protected field (accessible in derived classes)
        protected string _make;
        protected string _model;
        protected int _year;

        // Constructor for the base class
        public Vehicle(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
        }

        // Virtual method (can be overridden in derived classes)
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle Info: {_make} {_model}, Year: {_year}");
        }
    }

    // 2. Derived class (Child class) that inherits from Vehicle
    public class Car : Vehicle
    {
        private int _speed;

        // Constructor for the derived class (uses base class constructor)
        public Car(string make, string model, int year, int speed) : base(make, model, year)
        {
            _speed = speed;
        }

        // Method overriding (override the DisplayInfo method from the base class)
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Optionally call the base class method
            Console.WriteLine($"Current Speed: {_speed} km/h");
        }

        // New method specific to the Car class
        public void Accelerate(int increment)
        {
            _speed += increment;
            Console.WriteLine($"{_make} {_model} accelerated by {increment} km/h. Current speed: {_speed} km/h.");
        }
    }

    // 3. Another derived class (e.g., Truck)
    public class Truck : Vehicle
    {
        private int _cargoCapacity;

        // Constructor for the derived class (uses base class constructor)
        public Truck(string make, string model, int year, int cargoCapacity) : base(make, model, year)
        {
            _cargoCapacity = cargoCapacity;
        }

        // Method overriding (override the DisplayInfo method from the base class)
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Call the base class method
            Console.WriteLine($"Cargo Capacity: {_cargoCapacity} kg");
        }

        // New method specific to the Truck class
        public void LoadCargo(int weight)
        {
            if (weight <= _cargoCapacity)
            {
                Console.WriteLine($"Loading {weight} kg of cargo into the truck.");
            }
            else
            {
                Console.WriteLine($"Cannot load {weight} kg. Exceeds cargo capacity of {_cargoCapacity} kg.");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // 4. Creating an object of the Car class (derived class)
            Car myCar = new Car("Toyota", "Corolla", 2020, 100);
            myCar.DisplayInfo();  // Calls the overridden DisplayInfo method
            myCar.Accelerate(20); // Calls a method specific to the Car class

            Console.WriteLine(); // Just a line break

            // 5. Creating an object of the Truck class (derived class)
            Truck myTruck = new Truck("Ford", "F-150", 2019, 2000);
            myTruck.DisplayInfo();  // Calls the overridden DisplayInfo method
            myTruck.LoadCargo(1500); // Calls a method specific to the Truck class
        }
    }
}
