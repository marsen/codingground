using System.IO;
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        var mark = new Person("Mark",30);
        mark.Say();
        //delegate
        DelegateTest.Run();
        
        
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
    //
    public class DelegateTest{
        // Declare delegate -- defines required signature:
        delegate double MathAction(double num);
        
        // Regular method that matches signature:
        static double Double(double input)
        {
            return input * 2;
        }
        
        // Regular method that matches signature:
        static double Triple(double input)
        {
            return input * 3;
        }
        
        public static void Run(){
            // Instantiate delegate with named method: 
            MathAction ma1 = Double;

            var result = ma1(4.5);
            Console.WriteLine(result);
            LongTimeExe(ma1);
            //more about C# delegate 
            /*
            // Instantiate delegate with anonymous method:
            MathAction ma2 = delegate(double input)
            {
                return input * input;
            };
            double square = ma2(12);
            Console.WriteLine("square: {0}", square);
            
             // Instantiate delegate with lambda expression
            MathAction ma3 = s => s * s * s;
            double cube = ma3(9);

            Console.WriteLine("cube: {0}", cube);
            */
        }
        
        private static void LongTimeExe(MathAction ma){
            Thread.Sleep(3000);//a long time work
            var result = ma(9);
                        
            Console.WriteLine(result);
        }
    }
}
