using System;

namespace Lab_2B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Salesman's Name");
            var name = Console.ReadLine();

            Console.WriteLine("Enter Sales Amount");
      
            var x = Console.ReadLine();

            int sale = Convert.ToInt32(x);

            double commission =(sale * 0.09) + 200;


            Console.WriteLine("Sales Commission for " + name + " is " + " $" + commission);

            if (sale < 2999) 
            {
                Console.WriteLine("Performance is Poor");
            }
            
            if (sale >= 4999)
            if (sale <= 3000)
            {
                    Console.WriteLine("Performance is Average");
            }

            if (sale >= 5000)
            if (sale <= 9999)
                {
                    Console.WriteLine("Performance is Good");
                }

            if (sale >= 10000)
            if (sale <= 14999)
                {
                    Console.WriteLine("Performance is Excellent");
                }

            if (sale >= 15000)
            {
                Console.WriteLine("Performance is Outstanding");
            }



        }
    }
}