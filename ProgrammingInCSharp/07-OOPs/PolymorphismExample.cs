using System;

namespace OOPs.Polymorphism
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

    public class PolymorphismExample
    {
        public static void RunExample()
        {
            Console.WriteLine("\n--- Polymorphism Example ---");

            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myAnimal.Speak();
            myDog.Speak();
            myCat.Speak();

            Console.WriteLine();

            Calculator calc = new Calculator();
            Console.WriteLine($"Add(int, int): {calc.Add(5, 10)}");
            Console.WriteLine($"Add(double, double): {calc.Add(5.5, 10.2)}");
            Console.WriteLine($"Add(int, int, int): {calc.Add(5, 10, 15)}");
        }
    }
}
