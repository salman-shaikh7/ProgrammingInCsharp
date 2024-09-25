using System;

namespace OOPs
{
    // 1. Base class (Animal) demonstrating dynamic polymorphism (run-time polymorphism)
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    // 2. Derived class (Dog) overriding the Speak method
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    // 3. Derived class (Cat) overriding the Speak method
    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat meows.");
        }
    }

    // 4. Example of method overloading (compile-time polymorphism)
    public class Calculator
    {
        // Method overloading: Different method signatures for the Add method
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // 5. Demonstrating run-time polymorphism (method overriding)
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            // Call the Speak method on different objects (dynamic dispatch)
            myAnimal.Speak();  // Outputs: "The animal makes a sound."
            myDog.Speak();     // Outputs: "The dog barks."
            myCat.Speak();     // Outputs: "The cat meows."

            Console.WriteLine(); // Just a line break

            // 6. Demonstrating compile-time polymorphism (method overloading)
            Calculator calc = new Calculator();

            Console.WriteLine($"Add(int, int): {calc.Add(5, 10)}");        // Outputs: 15
            Console.WriteLine($"Add(double, double): {calc.Add(5.5, 10.2)}"); // Outputs: 15.7
            Console.WriteLine($"Add(int, int, int): {calc.Add(5, 10, 15)}");  // Outputs: 30
        }
    }
}
