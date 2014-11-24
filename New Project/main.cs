using System.IO;
using System;

class Program
{
    static void Main()
    {
        var mark = new Person("Mark",30);
        mark.Say();
    }
    
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    
        public void Say(){
            Console.WriteLine(string.Format("Hello, My name is {0}, I'm {1} years old!",Name,Age));
        }
    //Other properties, methods, events...
    }
}
