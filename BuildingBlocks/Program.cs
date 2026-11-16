using System;

namespace BuildingBlocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Datatypes variable
            //// 1 byte me  8 bit hoti h
            //int a = 5; // 4 bye
            //string b = "zaid"; // per each  character 2 byte
            //bool c = true;   // 1 bit
            //char d = 'A';  // 2 byte
            //float e = 123.76F;  // 4 byte
            //double f = 3435.676; // 6 byte

            Console.Write("Enter your name:\n");
            string name = Console.ReadLine();
            Console.Write("Enter your age:\n");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your address:\n");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Country name");
            string country = Console.ReadLine();
            Console.WriteLine("Enter your Father");
            string father = Console.ReadLine();

            Console.WriteLine("\n--- User dashboard ---");
            Console.WriteLine("welcome Name:" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Address:" + address);
            Console.WriteLine("Country:" +country);
            Console.WriteLine("father:" + father);
        }
    }
}
