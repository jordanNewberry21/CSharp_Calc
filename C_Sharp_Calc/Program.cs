using System;

namespace C_Sharp_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Do you want to add, subtract, multiply, or divide these two numbers? Please enter +, -, *, or / respectively. ");
            char operand = Convert.ToChar(Console.ReadLine());

            switch (operand)
            {
                case '+':
                    Console.WriteLine($"You entered: {num1} {operand} {num2}. Your solution is: {num1 + num2}.");
                    break;
                case '-':
                    Console.WriteLine($"You entered: {num1} {operand} {num2}. Your solution is: {num1 - num2}.");
                    break;
                case '*':
                    Console.WriteLine($"You entered: {num1} {operand} {num2}. Your solution is: {num1 * num2}.");
                    break;
                case '/':
                    Console.WriteLine($"You entered: {num1} {operand} {num2}. Your solution is: {num1 / num2}.");
                    break;
            }



            Console.ReadLine();
        }
    }
}
