using System;

namespace Task1
{
    public class Faculty
    {
        private string Name { get; set; }
        private Dean Dean { get; set; }
        private Speciality[] Specialitys { get; set; }
        public Faculty(string name, Dean dean, params Speciality[] specialitys)
        {
            Name = name;
            Dean = dean;
            Specialitys = specialitys;
        }
        public void Print()
        {
            Console.WriteLine("------Faculty------");
            Console.WriteLine("Name: " + Name);
            Dean.Print();
            foreach (Speciality speciality in Specialitys)
            {
                speciality.Print();
            }
        }
        public Speciality[] foundName(string name)
        {
            Speciality[] found = new Speciality[0];
            foreach (Speciality speciality in Specialitys)
            {
                if (speciality.Name == name)
                {
                    Array.Resize(ref found, found.Length + 1);
                    found[found.Length - 1] = speciality;
                }
            }
            return found;
        }
        public Speciality[] foundNumber(int num)
        {
            Speciality[] found = new Speciality[0];
            foreach (Speciality speciality in Specialitys)
            {
                if (speciality.Number == num)
                {
                    Array.Resize(ref found, found.Length + 1);
                    found[found.Length - 1] = speciality;
                }
            }
            return found;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Faculty faculty = new Faculty("CS", new Dean("name", "surname", 50), new Speciality(121, "x"), new Speciality(122, "xx"), new Speciality(123, "xxx"), new Speciality(124, "xxxx"));
            faculty.Print();
            Console.Write("Enter name to find: ");
            string name = Console.ReadLine() ?? "0";
            Faculty newFaculty = new Faculty("CS", new Dean("name", "surname", 50), faculty.foundName(name));
            newFaculty.Print();
            Console.Write("Enter num to find: ");
            int num = int.Parse(Console.ReadLine() ?? "0");
            Faculty newFaculty1 = new Faculty("CS", new Dean("name", "surname", 50), faculty.foundNumber(num));
            newFaculty1.Print();
        }
    }
}
