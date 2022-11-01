using System;

namespace Task1
{
    public class Speciality
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public Speciality(int number, string name)
        {
            Number = number;
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine("---Speciality---");
            Console.WriteLine("Number: " + Number);
            Console.WriteLine("Name: " + Name);
        }
    }
}
