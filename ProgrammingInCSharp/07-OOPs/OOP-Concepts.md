# Object-Oriented Programming (OOP) in C#

Object-Oriented Programming (OOP) is a programming paradigm that structures a program by bundling related properties and behaviors into objects. It emphasizes the concepts of **classes**, **inheritance**, and **polymorphism**, which allow for code reuse, flexibility, and scalability. This document explains these OOP concepts in the context of the C# examples created.

## 1. Classes and Objects

### Definition:
- A **class** is a blueprint for creating objects. It defines attributes (fields) and behaviors (methods) that describe the object.
- An **object** is an instance of a class, with its own set of data and the ability to invoke methods defined in the class.

### Reference: `ClassesAndObjects.cs`
- In the example, the class `Car` is defined with fields for attributes like `_make`, `_model`, and `_year`, and methods like `Accelerate()` and `Brake()`.
- When a **Car** object is created, it is initialized with values for these attributes using the **constructor**, and the methods can be called to interact with the object.

### Key Concepts:
- **Fields**: These are variables that hold data for the object. In the example, `Car` has fields for make, model, year, and speed.
- **Properties**: These provide controlled access to fields. They allow reading or writing the values of fields from outside the class, typically using `get` and `set` accessors.
- **Methods**: Functions that define the actions that can be performed by the object. For example, the `Accelerate()` method in the `Car` class increases the speed.
- **Constructor**: A special method that initializes an object when it is created. The `Car` class constructor sets the make, model, and year when a new `Car` object is instantiated.

### Objective:
- To introduce how to define a class, create objects, and call methods on those objects. This forms the foundation of object-oriented programming by showing how to model real-world entities as objects.

---

## 2. Inheritance

### Definition:
- **Inheritance** allows one class to inherit attributes and methods from another class. The class that inherits is called the **derived class** (or child class), and the class from which it inherits is the **base class** (or parent class).
- Inheritance promotes **code reuse** and allows for the creation of a more specialized class that extends or modifies the behavior of the base class.

### Reference: `InheritanceExample.cs`
- In the example, `Vehicle` is the base class that defines shared attributes such as make, model, and year. The derived classes `Car` and `Truck` inherit from `Vehicle` and add their own specific properties (e.g., speed for `Car` and cargo capacity for `Truck`).
- The **DisplayInfo()** method is defined in the base class `Vehicle`, but it is **overridden** in the `Car` and `Truck` classes to add more specific information.

### Key Concepts:
- **Protected Fields**: Inheritance uses the `protected` access modifier, which allows fields to be accessed within derived classes but not outside the class hierarchy. This balances encapsulation and flexibility in inherited classes.
- **Method Overriding**: The `Car` and `Truck` classes override the `DisplayInfo()` method from the base `Vehicle` class to provide more specific behavior, while still calling the base class method using `base.DisplayInfo()`.
  
### Objective:
- To demonstrate how inheritance enables code reuse and how the derived classes can override base class methods to provide specialized behavior. This illustrates the concept of building on top of existing classes without modifying them directly.

---

## 3. Polymorphism

### Definition:
- **Polymorphism** allows objects of different classes to be treated as objects of a common base class. It comes in two forms:
  1. **Compile-time Polymorphism**: Achieved through **method overloading**, where multiple methods with the same name but different signatures (parameters) exist within a class.
  2. **Run-time Polymorphism**: Achieved through **method overriding**, where a method in a derived class provides a specific implementation of a method defined in its base class.

### Reference: `PolymorphismExample.cs`
- **Method Overloading** is demonstrated in the `Calculator` class, where multiple `Add()` methods are defined with different parameter lists. This shows **compile-time polymorphism**, where the method to be called is determined by the method signature at compile time.
- **Method Overriding** is shown through the `Animal`, `Dog`, and `Cat` classes. The base class `Animal` defines a `Speak()` method, which is overridden in the `Dog` and `Cat` classes to provide specific behavior. This is an example of **run-time polymorphism**, where the actual method to be executed is determined by the object type at runtime.

### Key Concepts:
- **Method Overloading**: Allows a class to have multiple methods with the same name but different parameter lists. This is resolved at compile-time and is a way to perform polymorphism based on method signatures.
- **Method Overriding**: Allows a derived class to modify the behavior of a method defined in its base class. This is resolved at run-time, enabling dynamic behavior.
- **Dynamic Polymorphism**: With method overriding, the method that gets called is determined at runtime, based on the actual type of the object. For example, calling the `Speak()` method on an `Animal` object that references a `Dog` object will result in the `Dog`'s version of `Speak()` being executed.

### Objective:
- To show how polymorphism enables flexibility in code. By using base class references (such as `Animal`), different objects (`Dog`, `Cat`) can be treated uniformly, yet they behave according to their actual types. This allows for scalable and maintainable code, as adding new types (like `Bird`) doesn't require changing the base class or the polymorphic method.

---

## Summary of OOP Concepts

1. **Classes and Objects**:
   - Classes provide a structure for defining objects with attributes (fields) and behaviors (methods). Objects are instances of classes, and they are created using constructors.
   
2. **Inheritance**:
   - Inheritance allows one class to derive properties and methods from another class. It promotes code reuse and enables the creation of more specialized subclasses that extend the behavior of a base class. Through method overriding, derived classes can modify or extend the behavior of methods defined in the base class.

3. **Polymorphism**:
   - Polymorphism allows methods to take many forms. With method overloading (compile-time polymorphism), methods can have the same name but different signatures. With method overriding (run-time polymorphism), the method that gets executed depends on the actual type of the object at runtime, allowing for dynamic behavior.

---

## Why OOP Matters

- **Encapsulation**: OOP enables the bundling of data and behavior in a class, hiding internal details and exposing only what is necessary through properties and methods.
- **Abstraction**: OOP abstracts complex details, allowing the user to interact with objects at a higher level without needing to know their internal workings.
- **Inheritance**: Promotes code reuse and allows for building upon existing classes, reducing redundancy and improving maintainability.
- **Polymorphism**: Increases flexibility by allowing objects of different types to be treated uniformly, making the code more scalable and easier to extend.

---

This overview provides a comprehensive explanation of the key OOP principles using the examples defined in your `ClassesAndObjects.cs`, `InheritanceExample.cs`, and `PolymorphismExample.cs` files. The concepts of classes, inheritance, and polymorphism make C# and other OOP languages more modular, maintainable, and extensible.
