using System.Xml;

namespace Dědičnost
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }

            public Person (string name)
            {
                Name = name;
            }

            public virtual void SayHello()
            {
                Console.WriteLine($"Hello, my name is {Name}");
            }
            
        }
        class Student : Person
        {
            public string Grade {  get; set; }
            public Student (string name, string grade) : base (name)
            {
                Grade = grade;
            }
            
            public override void SayHello()
            {
                Console.WriteLine($"Hello, my name is {Name} and I am in {Grade} grade");            
            }
        }
        
        static void Main(string[] args)
        {
            Person myPerson = new Person("Sonia");
            Student myStudent = new Student("Sonia", "5");

            myPerson.SayHello();
            myStudent.SayHello();
        }
    }
}
