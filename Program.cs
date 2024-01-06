using System;

// Single Inheritance
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

// Single Inheritance
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

// Multilevel Inheritance
// Intermediate class inherits from a base class, and then another class inherits from the intermediate class (Multilevel Inheritance)
public class Mammal : Animal
{
    public void Sleep()
    {
        Console.WriteLine("Mammal is sleeping.");
    }
}

// Derived class inherits from an intermediate class (Multilevel Inheritance)
public class DogMammal : Mammal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

// Hierarchical Inheritance
// Multiple classes inherit from a single base class (Hierarchical Inheritance)
public class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing.");
    }
}

// Usage
class Program
{
    static void Main()
    {
        // Single Inheritance
        Dog myDog = new Dog();
        myDog.Eat();  // Inherited from Animal
        myDog.Bark(); // Specific to Dog

        // Multilevel Inheritance
        DogMammal myDogMammal = new DogMammal();
        myDogMammal.Eat();   // Inherited from Animal
        myDogMammal.Sleep(); // Inherited from Mammal
        myDogMammal.Bark();  // Specific to Dog

        // Hierarchical Inheritance
        Cat myCat = new Cat();
        myCat.Eat();  // Inherited from Animal
        myCat.Meow(); // Specific to Cat
    }
}
