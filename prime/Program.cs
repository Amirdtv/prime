using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Prime_Number
    {
        private int num1;
        private int num2;
        public int Num1
        {
            get { return num1; }
            set
            {
                if (value > 0)
                {
                    num1 = value;
                }
            }
        }
        public int Num2
        {
            get { return num2; }
            set
            {
                if (value > 0)
                {
                    num2 = value;
                }
            }
        }
        public Prime_Number() { }
        public Prime_Number(int Num1, int Num2)
        {
            num1=Num1;
            num2=Num2;
        }
        public void Print_number()
        {
            for (int i = num1; i <= num2; i++)
            {
                int counter = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter < 1)
                {
                    Console.WriteLine("Number " + i + " is Prime");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = Convert.ToInt32(Console.ReadLine());
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Prime_Number pr = new Prime_Number(Num1,Num2);
            pr.Print_number();
            Console.ReadKey();
        }
    }
}