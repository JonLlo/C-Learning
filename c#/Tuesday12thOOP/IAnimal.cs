using System;

namespace MessingWithOOP;

public interface IAnimal
{
    string Name { get; }
    int Age { get; }

    void Sleeps();
    void Eats();
    void MakeSound();
    
}