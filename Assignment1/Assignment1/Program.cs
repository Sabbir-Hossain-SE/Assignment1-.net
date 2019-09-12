using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        public string name = "", contact = "", address = "";
        public int age;
        public void input()
        {
            Console.WriteLine("Enter your full name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your address:");
            address = Console.ReadLine();
            Console.WriteLine("Enter your phone number:");
            contact = Console.ReadLine();
        }
        public void output()
        {
            Console.WriteLine(" Name:\t" + name + "\n Age:\t" + age + "\n Address:\t" + address + "\n Phone Number:\t" + contact);
        }

        static void Main(string[] args)
        {
            Program data = new Program();
            data.input();
            Console.WriteLine("*******************************************************");
            data.output();
            Console.ReadKey();
        }
    }
}
