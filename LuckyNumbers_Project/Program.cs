using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a starting number. ");
            Console.ReadLine();
            Console.WriteLine("Please enter an ending number. ");
            Console.ReadLine();

            int[] luckyNum = { 2, 5, 7, 9, 11, 14, };
            foreach (int luck in luckyNum)
            {
                Console.WriteLine("You're lucky number is: " + luck);

            //I COMPLETELY UNDERSTAND THE CONSEQUENCES OF THIS NOT BEING COMPLETE. IM WORKING ON 
            //HAVING A BETTER SCHEDULE IN ORDER TO COMPLETE ALL ASSIGNMENTS AND TO MAINTAIN 
            //MY ATTENDANCE.
            }
        }
    }
}
