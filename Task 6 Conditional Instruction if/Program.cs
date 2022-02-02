using System;

namespace Task_6_Conditional_Instruction_if
{
    class Program
    {
        static void Main(string[] args)
        {
            // A: Ask the user for a number.
            Console.WriteLine("Please enter some number.");

            // B: Load user entered number.
            int sn = int.Parse(Console.ReadLine());

            // C: If the user-specified number is greater than or equal to 10, show the + sign.
            if (sn >= 10)
            {
                Console.WriteLine("+");
            }

            // D: If the number entered by the user is less than 10, show the sign -.
            if (sn < 10)
            {
                Console.WriteLine("-");
            }
        }
    }
}
