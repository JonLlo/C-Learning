namespace MessingWithOOP
{
    public class Cat : Animal
    {
        //Attribute
        public string Breed { get; }
        //Constructor
        public Cat(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }
        public override void Sleeps()
        
        {
            Console.WriteLine($"{Name} is now sleeping!");
        }
    
        
    }
}