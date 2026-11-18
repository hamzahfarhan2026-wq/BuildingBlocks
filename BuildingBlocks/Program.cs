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

            //Console.Write("Enter your name:\n");
            //string name = Console.ReadLine();
            //Console.Write("Enter your age:\n");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter your address:\n");
            //string address = Console.ReadLine();
            //Console.WriteLine("Enter Country name");
            //string country = Console.ReadLine();
            //Console.WriteLine("Enter your Father");
            //string father = Console.ReadLine();

            //Console.WriteLine("\n--- User dashboard ---");
            //Console.WriteLine("welcome Name:" + name);
            //Console.WriteLine("Age:" + age);
            //Console.WriteLine("Address:" + address);
            //Console.WriteLine("Country:" +country);
            //Console.WriteLine("father:" + father);





            //statement 
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter your grade");
                int Grade = Convert.ToInt32(Console.ReadLine());
                if (Grade >= 90)
                {
                    Console.WriteLine("A+");
                }
                else if (Grade >= 80)
                {
                    Console.WriteLine("A");
                }
                else if (Grade >= 70)
                {
                    Console.WriteLine("B");
                }
                else if (Grade >= 60)
                {

                    Console.WriteLine("C");
                }
                else if (Grade >= 50)
                {
                    Console.WriteLine("D");
                }
                else { Console.WriteLine("Fail"); }
                Console.WriteLine("------------------------------------------------------------\n");
                Console.WriteLine("press key 'R'to view new window");
                Console.WriteLine("press any key to exit");
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key !=ConsoleKey.R) {
                    break;
                }
            }
        }
    }
}
