using System;

class Program
{
    public static void Main()
    {
        Person p1 = new Person("Trevor", "Smith", 21);
        Person p2 = new Person();
        Person p3 = new Person("Trevor", "Jones");


        p1.ShowInfo();
        p1.IncreaseAgeByOne();
        p1.ShowInfo();
        p2.ShowInfo();
        p3.ShowInfo();



    }
}

