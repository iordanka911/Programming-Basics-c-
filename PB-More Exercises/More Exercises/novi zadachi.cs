using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Creating_class
{
    class accept
    {
        public string name;
        public void acceptdetails()
        {
            Console.Write("Enter your name:\t");
            name = Console.ReadLine();
        }
    }
    class print
    {
        public void printdetails()
        {
            accept a = new accept();
            a.acceptdetails();
            Console.WriteLine("Your name is "+a.name);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            print p = new print();
            p.printdetails();
            Console.ReadLine();
        }
    }
}


1.Print name
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Creating_class
{
    class print
    {
        public void printname()
        {
            Console.WriteLine("My name is Iordanka Jekova!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            print pr = new print();
            pr.printname();
        }
    }
}

Print name/city/age
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Creating_class
{
    class Program
    {
        string name, city;
        int age;
        public void acceptdetails()
        {
            Console.Write("\nEnter your name:\t");
                name = Console.ReadLine();

            Console.Write("\nEnter your City:\t");
            city = Console.ReadLine();

            Console.Write("\nEnter your age:\t\t");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void printdetails()
        {
            Console.Write("\n\n====================");
            Console.Write("\nName:\t" + name);
            Console.Write("\nCity:\t" + city);
            Console.Write("\nAge:\t" + age);
            Console.Write("\n====================\n");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.acceptdetails();
            p.printdetails();
            Console.ReadLine();
        }
    }
        
    
}


using System;

namespace ConsoleApp58
{
    class Windows
    {
        static void Main(string[] args)
        {
            double width, height, woodLengght, glassArea;
            string widthString, heightString;
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            double woodLength = 2 * (width + height);
            glassArea = width * height;
            Console.WriteLine($"Необходимо количество дърво {woodLength} m");
            Console.WriteLine("Необходима площ стъкло "
            + glassArea + "square meters");
        }
    }
}
    


