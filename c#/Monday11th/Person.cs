


public class Person
{

    //attributes 
    public string firstName;

    public string lastName { get; set; }
    public byte age { get; set; }

    //Computed Attribute or Computed Property
    public string fullName => $"{firstName} {lastName}";


    //Lets add some constructors

    //Parameterised constructors
    public Person(string FirstName, string LastName, byte Age)
    {
        firstName = FirstName;
        lastName = LastName;
        age = Age;
    }

    //person with no age
    public Person(string FirstName, string LastName)
    {
        firstName = FirstName;
        lastName = LastName;
        age = 0;


    }

    //Default Constructor

    public Person()
    {
        firstName = "No First Name";
        lastName = "No Last Name";
        age = 0;
    }

    //METHOD

    public void IncreaseAgeByOne()
    {
        age++;
    }

    public void ShowInfo()
    {
        DisplayInfo();
    }

    private void DisplayInfo()
    {
        Console.WriteLine($"Name: {fullName}, Age: {age}");

    }

  
  



}