using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person._firstName = "John";
        person._lastName = "Baptist";
        person._age = 38;

        string _fullName = person._firstName + " " + person._lastName;
        Console.WriteLine("Full name:" + _fullName);
    }
}