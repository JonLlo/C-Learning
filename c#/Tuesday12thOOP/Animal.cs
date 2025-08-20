using System;
namespace MessingWithOOP
{
    public abstract class Animal
    {

        //This is all encapsulation - as note "_name" and "_age" are not used in program.cs, 
        //they are encapsulated (I think)
        private string _name;
        private int _age;
        // Public properties:
        //Better for hiding the data
        public string Name
        {
            get { return _name; }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be negative.");
                }
            }
        }


        // Constructor
        public Animal(string name, int age)
        {
            _name = name;
            _age = age;
        }

        //Methods for doing stuff
        //virtual allows for override (see dog.cs) -> example of Polymorphism

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} goes purr and sometimes meow");
        }
        public virtual void Eats()
        {
            Console.WriteLine($"{Name} eats tuna!");
        }

        //abstract methods don't do anything
        //It basically ENSURES that an error shows unless every derived class makes use of it.
        //It would actually make more sense to make all the above (makesound, eats etc) abstract.
        public abstract void Sleeps();



    }
}