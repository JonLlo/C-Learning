/*
NOT TO DO WITH INHERITANCE
public class Program
{
    public static void Main()
    {
        Calculator calc = new Calculator();
        int num1, num2;
        num1 = 4;
        num2 = 5;

        int result = Calculator.Add(num1, num2);
        Console.WriteLine(result);

        result = calc.Multiply(num1, num2);
        Console.WriteLine(result);
    }
}
*/

//OOP1
using System;
using MessingWithOOP; // <--- This makes Animal visible here
public class Program
{
    //instance of the Animal Class
    private static void Main(string[] args)
    {



        //Animal cat = new Animal("Tiddles", 6);
        //Console.WriteLine($"Name: {cat.Name}, Age: {cat.Age}");
        //cat.MakeSound();
        //cat.Eats();
        //cat.Age = -1;
        //Console.WriteLine($"Name: {cat.Name}, Age: {cat.Age}");

        //    Animal chicken = new Animal("Bubbles", 1);
        //    chicken.MakeSound();
        //    chicken.Eats();

        Cat Tiddles = new Cat("Tiddles", 6, "Tabby");
        Tiddles.Eats();
        Tiddles.MakeSound();


        Dog Fido = new Dog("Fido", 5, "Bulldog");
        Fido.Eats();
        Fido.MakeSound();
        //note tiddles can't wag tail....
        Fido.WagsTail();

        Fish Nemo = new Fish("Nemo", 3, "Goldfish");
        Nemo.Eats();
        Nemo.MakeSound();
        Nemo.Swims();

        Nemo.Sleeps();

        Bird Tweety = new Bird("Tweety", 2, "Canary");
        Fish Flubber = new Fish("Flubber", 3, "Clownfish");
        Tweety.Eats();
        Tweety.MakeSound();

        List<Animal> petshop = new List<Animal>();
        petshop.Add(Tiddles);
        petshop.Add(Nemo);
        petshop.Add(Tweety);
        petshop.Add(Flubber);
        //cant add fido as it is dog comes under ianimal but not animal

        List<IAnimal> exceptionalPetShop = new List<IAnimal>();
        exceptionalPetShop.Add(Fido);
        //cant add tiddles as it is cat comes under animal but not ianimal

        foreach (Animal animal in petshop)
        {
            Console.WriteLine($"{animal.Name} is {animal.Age} years old.");
            animal.Sleeps();
            animal.Eats();
            animal.MakeSound();
        }


    }
}