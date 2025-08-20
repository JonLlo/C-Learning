



// This line allows us to use built-in things like Console.WriteLine
using System;


// A class is like a blueprint or recipe for making objects.
// Imagine this like a "Machine" that knows how to do certain tasks.

public class BaseClass
{

    // "public" means anyone can use this method — like a button on the outside of a machine.
    // "void" means this method DOES something but does NOT give anything back (no return value).

    public void PublicMethod()
    {
        Console.WriteLine("Public Method"); // Think of this as printing a message on a screen.
    }

    // "private" means this method is hidden — only the machine itself can use this.
    // You can think of it like an internal lever or tool that only the machine knows about.
    private void PrivateMethod()
    {
        Console.WriteLine("Private Method");
    }

    // "protected" means this method is available to the machine AND any other machines built from it.
    // Like a tool that only this machine and its children machines can use.
    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected Method");
    }
    // "internal" means only things in the same factory (project) can access it.
    // If someone is in the same workspace, they can use this function.

    internal void InternalMethod()
    {
        Console.WriteLine("Internal Method");
    }
    // "protected internal" is a mix:
    // - Can be used in subclasses (child machines)
    // - Or by other classes in the same factory (project)
    protected internal void ProtectedInternalMethod()
    {
        Console.WriteLine("Protected Internal Method");
    }

    // "private protected" is more strict:
    // - Can be used by subclasses, BUT only if they are in the same factory (project)
    private protected void PrivateProtectedMethod()
    {
        Console.WriteLine("Private Protected Method");
    }

    // This method will test all of the above methods
    // Because we're still inside the same machine (BaseClass), we are allowed to use all of them
    public void CallAllMethods()
    {
        Console.WriteLine("Calling all methods from BaseClass:");
        PublicMethod();             // ✅ Allowed
        PrivateMethod();            // ✅ Allowed (same class)
        ProtectedMethod();          // ✅ Allowed
        InternalMethod();           // ✅ Allowed (same project)
        ProtectedInternalMethod();  // ✅ Allowed
        PrivateProtectedMethod();   // ✅ Allowed
    }

    public void PrintDonkey()
    {
        Console.WriteLine("Donkey");
    }

}

/*
// This is another machine: Programme
// Every C# app must have a Main method — this is where your program starts running
public class ProgramTest
{
    // "static" means you can run this without making an object first.
    // Think of it like pressing a START button that just exists — not tied to any machine instance.

    // "void" again means it doesn't return anything — it just runs.
    public static void Main()
    {
        // Create a new object of type BaseClass — like building a machine from the blueprint
        BaseClass baseObj = new BaseClass();

        // Call the method that runs all the other access tests
        baseObj.CallAllMethods();
        Other();

        // Expected Output:
        // Public Method
        // Private Method
        // Protected Method
        // Internal Method
        // Protected Internal Method
        // Private Protected Method
    }
    public static void Other()
    {
        // Create a new object of type BaseClass — like building a machine from the blueprint
        BaseClass donkeyObj = new BaseClass();

        // Call the method that runs all the other access tests
        donkeyObj.PrintDonkey();

        // Expected Output:
        // Public Method
        // Private Method
        // Protected Method
        // Internal Method
        // Protected Internal Method
        // Private Protected Method
    }
}
*/




// DerivedClass is a "child machine" built from the "BaseClass" blueprint.
// It inherits all the tools and parts from BaseClass.

public class DerivedClass : BaseClass
{
    // This method tries to use all the methods from BaseClass to see which ones are accessible.
    public void TestAccess()
    {
        PublicMethod();             // ✅ Public: This button is outside, everyone can press it.

        // PrivateMethod();         // ❌ Private: This lever is hidden inside BaseClass, child machines can't use it.

        ProtectedMethod();          // ✅ Protected: This tool is passed down to child machines.

        InternalMethod();           // ✅ Internal: This tool is available if child is in the same factory (project).

        ProtectedInternalMethod();  // ✅ Protected Internal: This tool is for child machines OR anyone in the same factory.

        PrivateProtectedMethod();   // ✅ Private Protected: This tool is for child machines but only if in the same factory.
    }
}

// OtherClass is an independent machine, NOT built from BaseClass blueprint.
// It just *uses* BaseClass by creating one.



// OtherClass is an independent machine, NOT built from BaseClass blueprint.
// It just *uses* BaseClass by creating one.
public class OtherClass
{
    public void TestAccess()
    {
        BaseClass obj = new BaseClass(); // Create a BaseClass machine to use its buttons/tools.
        
        obj.PublicMethod();              // ✅ Public: Everyone can use this button.
        
        // obj.PrivateMethod();         // ❌ Private: Hidden inside BaseClass, cannot be used here.
        
        // obj.ProtectedMethod();       // ❌ Protected: Only child machines can use this, not others.
        
        obj.InternalMethod();           // ✅ Internal: Anyone inside the same factory can use this.
        
        obj.ProtectedInternalMethod();  // ✅ Protected Internal: Anyone in the factory OR child machines can use.
        
        // obj.PrivateProtectedMethod(); // ❌ Private Protected: Only child machines in the same factory.
    }
}

//public class Program
// This is another machine: Programme
// Every C# app must have a Main method — this is where your program starts running
public class Program
{
    public static void Main()
    {
        PrintHello();
        Print("Hello World!");
        int num1 = 3;
        int num2 = 11;
        int value = AddNumbers(num1, num2);
        Print(value);
        float floatValue = AddNumbers(3.525f, 2.5f);

        Print(floatValue);


        //Calculate the area of a circle:

        int radius = 4;
        double area = AreaOfCircle(radius);
        Print(area);

    }
    private static double AreaOfCircle(int radius)
    {
        return 3.14159265 * radius * radius;
    }

    static void PrintHello()
    {
        Console.WriteLine("Hello");
    }

    static void Print(string message)
    {
        Console.WriteLine(message);
    }
    static void Print(int value)
    {
        Console.WriteLine(value);
    }


    static int AddNumbers(int number1, int number2)
    {
        return number1 + number2;
    }
    static float AddNumbers(float number1, float number2)
    {
        return number1 + number2;
    }
    static void Print(float num)

    {

        Console.WriteLine(num);

    }
      static void Print(double num)

    {

        Console.WriteLine(num);

    }

    }


//Lesson 11: Classes and Objects (11th August)

