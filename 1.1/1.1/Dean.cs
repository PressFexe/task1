using System;

namespace Task1
{
    public class Dean
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private int Age { get; set; }
        public Dean(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public void Print()
        {
            Console.WriteLine("---Dean:---");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Age: " + Age);
        }
    }
}
