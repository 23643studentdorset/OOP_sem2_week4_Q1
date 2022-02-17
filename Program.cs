using System;

namespace OOP_sem2_week4_Q1
{
    class Program
    {
        /*
         * Create a console-based application whose Main() method asks the user to input an integer
           and then calls a method named MultiplicationTable(), which displays the results of
           multiplying the integer by each of the numbers 2 through 10
        */
        private static void multiplicationTable(int number)
        {

            int result = 0;
            for (int i=2; i <= 10; i += 2)
            {
                result = i * number;
                Console.WriteLine(number);
            }
            
        }







        static void Main(string[] args)
        {

            bool flag = false;
            int number = 0;
            do
            {
                Console.WriteLine("input an integer");
                flag = !int.TryParse(Console.ReadLine(), out number);
                if (flag)
                {
                    Console.WriteLine("The value is not an integer");
                }
            } while (flag);

            multiplicationTable(number);

        }
    }
}
