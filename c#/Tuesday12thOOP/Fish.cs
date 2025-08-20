namespace MessingWithOOP
{
    public class Fish : Animal, ISwimmable
    {
        //attributes
        public string Breed { get; }
        //constructor
        public Fish(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }

        //methods to override makesound and eats
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} goes 'get me out of the sea'");
        }
        public override void Eats()
        {
            Console.WriteLine($"{Name} eats smaller fish");
        }

        public void Swims()
        {
            Console.WriteLine($"{Name} swims around the sea!");
        }

        public override void Sleeps()
        {
            Console.WriteLine($"{Name} is now sleeping!");
        }
        public void Swim()
        {
            Console.WriteLine("I'm Swimming!");
        }
        public void Dive()
        {
            Console.WriteLine("I can do Dive and I am a fish!");
        }
        
    }
    
}