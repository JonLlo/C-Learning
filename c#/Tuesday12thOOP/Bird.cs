namespace MessingWithOOP
{
    public class Bird : Animal, IFlyable
    {
        //Attributes
        public string Breed { get; }
        //Constructor
        public Bird(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }
        public override void Sleeps()

        {
            Console.WriteLine($"{Name} is now sleeping!");
        }
        public override void Eats()
        {
            Console.WriteLine($"{Name} is eating seeds!");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says tweet!");
        }

        public void Fly()
        {
            Console.WriteLine("Hey I am flying!");
            
        }
    
        
    }
}