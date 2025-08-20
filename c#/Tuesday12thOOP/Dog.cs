namespace MessingWithOOP
{
    public class Dog : IAnimal, IWalkable, ISwimmable
    {
        //attributes
        public string Name { get; }
        public int Age { get; }
        public string Breed { get; }

        //constructor
        public Dog(string name, int age, string breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }

        //methods to override makesound and eats
        public void MakeSound()
        {
            Console.WriteLine($"{Name} goes woof");
        }
        public void Eats()
        {
            Console.WriteLine($"{Name} eats the occasional postman");
        }

        public void WagsTail()
        {
            Console.WriteLine($"{Name} wags their tail!");
        }

        public void Sleeps()
        {
            Console.WriteLine($"{Name} is now sleeping!");
        }
        public void Walk()
        {
            Console.WriteLine("walking a slow pace");
        }
        public void Run()
        {
            Console.WriteLine("Hey I'm pulling you");
        }
        public void Swim()
        {
            Console.WriteLine("Doggy Paddling!");
        }
        public void Dive()
        {
            Console.WriteLine("Diving!");
        }
    }
    
}