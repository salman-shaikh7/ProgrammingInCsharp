using System;

namespace OOPs.ClassesAndObjects
{
    public class Vehicle
    {
        protected string _make;
        protected string _model;
        protected int _year;

        public Vehicle(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {_make} {_model} ({_year})");
        }
    }

    public class Car : Vehicle
    {
        private int _speed;

        public Car(string make, string model, int year, int speed) : base(make, model, year)
        {
            _speed = speed;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Speed: {_speed} km/h");
        }
    }

    public class ClassesAndObjectsExample
    {
        public static void RunExample()
        {
            Console.WriteLine("\n--- Classes and Objects Example ---");

            Car car = new Car("Honda", "Civic", 2021, 150);
            car.DisplayInfo();
        }
    }
}
