# Object-Oriented Programming (OOP) in C#

Object-Oriented Programming (OOP) is a programming paradigm that organizes software design around data, or **objects**, rather than functions and logic. In C#, OOP focuses on creating reusable code through the use of **classes**, **objects**, **methods**, **fields**, and **constructors**. This document explains these core OOP concepts in detail with references to example files from the repository.

---

## 1. Classes and Objects

### What is a Class?

A **class** is a blueprint or template for creating objects. It encapsulates data (fields) and methods (functions) that operate on that data. A class in C# defines the properties and behaviors that objects created from the class will have.

### What is an Object?

An **object** is an instance of a class. While the class provides the structure, the object holds actual data and allows the use of methods defined by its class. Each object can have its own state, represented by the values of its fields, even if multiple objects are created from the same class.

**Reference**: [`ClassesAndObjects.cs`](./07-OOPs/ClassesAndObjects.cs)

This file contains an example of the `Car` class, which includes fields like `_make`, `_model`, and `_year`. When the `Car` object is created, the constructor initializes these fields, and methods like `DisplayInfo()` can be called to display the car’s details.

---

## 2. Fields and Methods

### Fields

**Fields** are variables that hold the data for an object. They define the properties or characteristics of the object. Fields are typically private, meaning they cannot be accessed directly outside the class, but can be accessed and modified using **public properties** or **methods**.

### Methods

**Methods** are functions defined within a class that describe the behaviors or actions that objects of the class can perform. Methods operate on the data contained in the object’s fields.

**Reference**: In the [`ClassesAndObjects.cs`](./07-OOPs/ClassesAndObjects.cs) file, the `Car` class defines the method `DisplayInfo()` to output the car's details. 

---

## 3. Constructors

### What is a Constructor?

A **constructor** is a special method that is called automatically when an object of the class is created. It is used to initialize the object’s fields. A constructor has the same name as the class and does not return any value, not even `void`.

**Reference**: The constructor in the `Car` class (found in [`ClassesAndObjects.cs`](./07-OOPs/ClassesAndObjects.cs)) takes parameters like `make`, `model`, and `year`, and uses them to initialize the fields of the `Car` object.

---

## 4. Access Modifiers

### What are Access Modifiers?

Access modifiers in C# determine the visibility of classes, methods, and fields. They control how and where the data or methods of a class can be accessed.

- **public**: The member is accessible from any code within the application.
- **private**: The member is accessible only within the class it is defined in.
- **protected**: The member is accessible within its class and any derived classes.
- **internal**: The member is accessible only within files in the same assembly.
- **protected internal**: The member is accessible within its class, derived classes, and files within the same assembly.

---

## 5. Properties

**Properties** in C# provide a flexible mechanism to read, write, or compute the values of private fields. Properties use **get** and **set** accessors to control how values are assigned and retrieved from the object’s fields.

**Reference**: You can see an example of this in [`ClassesAndObjects.cs`](./07-OOPs/ClassesAndObjects.cs), where the `Car` class could have properties to get and set the values of `_make`, `_model`, and `_year`.

---

## 6. Encapsulation

**Encapsulation** is the concept of wrapping data (fields) and code (methods) together into a single unit, a class. By using access modifiers (e.g., private, public), encapsulation controls access to the object’s internal state, protecting its integrity and preventing unwanted or incorrect manipulation.

---

## 7. Inheritance

### Definition:
- **Inheritance** allows one class (child class) to inherit attributes and methods from another class (parent class). This promotes code reuse and creates a hierarchical structure.
- The class that inherits from another class is called the **derived class** (or child class), and the class being inherited from is called the **base class** (or parent class).

**Reference**: [`InheritanceExample.cs`](./07-OOPs/InheritanceExample.cs)

In this file, the `Vehicle` class acts as the base class, and the `Car` class inherits its fields (`_make`, `_model`, and `_year`) while also adding its own field `_speed`.

### Why Inheritance Matters:

- **Code Reuse**: Inheritance allows classes to share common fields and methods, reducing code duplication.
- **Flexibility**: The derived class can override or extend base class functionality to meet specific needs.

---

## 8. Polymorphism

### Definition:
- **Polymorphism** is the ability of objects to take many forms. It enables methods to behave differently based on the object that is invoking the method. There are two types of polymorphism:
  - **Compile-time polymorphism** (method overloading)
  - **Run-time polymorphism** (method overriding)

### 8.1 Compile-time Polymorphism (Method Overloading)

In **method overloading**, multiple methods with the same name can exist in a class, but they must have different signatures (parameters).

**Reference**: [`PolymorphismExample.cs`](./07-OOPs/PolymorphismExample.cs)

The `Calculator` class in this file demonstrates method overloading with multiple `Add()` methods that accept different numbers and types of parameters.

---

### 8.2 Run-time Polymorphism (Method Overriding)

**Run-time polymorphism** allows methods to be overridden in derived classes. This is done using the `virtual` keyword in the base class and the `override` keyword in the derived class.

**Reference**: [`PolymorphismExample.cs`](./07-OOPs/PolymorphismExample.cs)

In this file, the `Animal` class defines the `Speak()` method as `virtual`, and the `Dog` and `Cat` classes override this method with their own specific implementations.

### Why Polymorphism Matters:

- **Flexibility**: Allows different classes (e.g., `Dog`, `Cat`) to be treated uniformly through their base class (`Animal`), while still behaving differently based on the object type.
- **Scalability**: Polymorphism makes it easy to extend the code by adding new types without modifying existing code.

---

## 10. Interfaces

### Definition:
An **interface** in C# is a contract that defines a set of methods or properties that a class must implement. Unlike classes, interfaces do not contain any implementation code for their members. Instead, they only declare the structure that implementing classes must follow. A class can implement multiple interfaces, allowing for greater flexibility and modularity in design.

Interfaces allow for defining common functionality that different classes can implement in their own ways.

### Reference: [`InterfaceExample.cs`](./07-OOPs/InterfaceExample.cs)

In this file, the `IVehicle` interface declares methods such as `Start()`, `Stop()`, `Drive(int speed)`, and `DisplayInfo()`. Both `Car` and `Truck` implement these methods, but each has its own distinct behavior:
- **Car Class**: Implements the `Drive()` method to adjust and display the current speed.
- **Truck Class**: Implements the `Drive()` method to display the speed but also adds truck-specific behavior, like managing cargo weight.

This demonstrates how interfaces enforce a contract, while allowing different behaviors for each class.

### Key Concepts:
- **Defining an Interface**: An interface is defined using the `interface` keyword. It contains method signatures but no method bodies.
- **Implementing an Interface**: A class implements an interface using the `: InterfaceName` syntax. The class must then provide concrete implementations for all the methods and properties defined in the interface.
- **Polymorphism with Interfaces**: When a class implements an interface, objects of that class can be treated as objects of the interface type. This allows for flexibility in using different objects with a common interface in the same way.

### Why Interfaces Matter:
- **Separation of Concerns**: Interfaces separate the definition of behaviors from their implementation, promoting cleaner code design.
- **Flexibility**: Interfaces provide flexibility by allowing multiple classes to implement the same set of behaviors in their own way.
- **Multiple Implementations**: A class can implement multiple interfaces, allowing it to conform to various contracts and making the code more modular.

### Example:

In the `InterfaceExample.cs`, both the `Car` and `Truck` classes implement the `IVehicle` interface. Each class provides its specific implementation for methods like `Start()` and `Drive()`, showcasing how interfaces enforce a contract while allowing different behavior across classes.

### Summary:
- **IVehicle Interface**: Declares methods such as `Start()`, `Stop()`, `Drive(int speed)`, and `DisplayInfo()`.
- **Car and Truck Classes**: Implement the `IVehicle` interface, each providing its specific behavior for the methods.
- **Polymorphism**: The interface allows `Car` and `Truck` objects to be treated as `IVehicle` instances, demonstrating the flexibility of polymorphism in object-oriented programming.


---

## 10. Summary of OOP Concepts

1. **Classes and Objects**:
   - Classes define the structure, and objects are instances of classes. Use constructors to initialize objects.

2. **Fields and Methods**:
   - Fields store object data, and methods define the behaviors of an object.

3. **Inheritance**:
   - Enables code reuse by allowing a child class to inherit methods and fields from a parent class.

4. **Polymorphism**:
   - Allows for method overloading and overriding, providing flexibility and dynamic behavior.

5. **Interfaces**:
   - Define a contract that classes can implement. Interfaces specify methods that must be implemented by any class that inherits from the interface, allowing different classes to provide specific implementations. This promotes a uniform method structure across diverse classes while allowing for flexibility in behavior.

---

## Why OOP Matters

- **Encapsulation**: Protects the integrity of an object's internal state.
- **Abstraction**: Simplifies complex systems by hiding unnecessary details.
- **Inheritance**: Promotes code reuse and improves maintainability.
- **Polymorphism**: Increases flexibility and scalability, allowing objects to behave differently based on their actual type.
- **Interfaces**: Enhance flexibility by allowing classes to implement multiple interfaces, supporting a decoupled design that adheres to the principle of programming to an interface rather than an implementation. This makes the code more modular and easier to maintain.

