using System;

namespace OOPs
{
    // 1. Defining a Class: Car
    public class Car
    {
        // Fields (private by default)
        private string _make;
        private string _model;
        private int _year;
        private int _speed;

        // 2. Constructor (to initialize objects)
        public Car(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
            _speed = 0; // Default speed when a car is created
        }

        // 3. Properties (to access private fields)
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        // Read-only property
        public int Speed
        {
            get { return _speed; }
        }

        // 4. Methods (behavior of the class)
        public void Accelerate(int increment)
        {
            _speed += increment;
            Console.WriteLine($"{_make} {_model} accelerated by {increment} km/h. Current speed: {_speed} km/h.");
        }

        public void Brake(int decrement)
        {
            _speed -= decrement;
            if (_speed < 0) _speed = 0; // Speed cannot be negative
            Console.WriteLine($"{_make} {_model} slowed down by {decrement} km/h. Current speed: {_speed} km/h.");
        }

        // 5. Method to display the car's details
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car Info: {_make} {_model}, Year: {_year}, Current Speed: {_speed} km/h.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // 6. Object instantiation using constructor
            Car myCar = new Car("Toyota", "Corolla", 2020);

            // 7. Accessing properties
            Console.WriteLine($"Car Make: {myCar.Make}");
            Console.WriteLine($"Car Model: {myCar.Model}");
            Console.WriteLine($"Car Year: {myCar.Year}");

            // 8. Calling methods
            myCar.DisplayCarInfo();
            myCar.Accelerate(20);   // Increase speed
            myCar.Brake(10);        // Decrease speed
            myCar.Accelerate(30);   // Increase speed
            myCar.Brake(50);        // Attempt to stop the car (speed should not go below 0)

            // Display the final state
            myCar.DisplayCarInfo();
        }
    }
}
