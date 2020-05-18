using Calculator.Classes;
using Calculator.ENUMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTitle();
            AskForValues();
        }

        /// <summary>
        /// Creates the calculator and starts to process of asking the user the values.
        /// </summary>
        private static void AskForValues()
        {
            SimpleCalculator mySCalculator = new SimpleCalculator();

            mySCalculator.SetValue(GetAValue());
            mySCalculator.SetOperation(GetAOperation());
            mySCalculator.SetValue(GetAValue());

            mySCalculator.Calculate(out float result);
            Console.WriteLine("Result: " + result);

            Console.WriteLine("Press any key to repeat or 'Esc' to exit");
            if (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                AskForValues();
            }
        }

        /// <summary>
        /// Asks the user for a value, if that value is valid it returns it, else asks the user for a new one.
        /// </summary>
        /// <returns>Float, the value inserted by the user.</returns>
        private static float GetAValue()
        {
            Console.WriteLine("Please write a value:");
            var strVal = Console.ReadLine();

            if (float.TryParse(strVal, out float val))
            {
                return val;
            }
            else
            {
                Console.WriteLine("A problem occurred while trying to read the value.");
                return GetAValue();
            }
        }

        /// <summary>
        /// Asks the user for a operation, if that operation is valid it returns it, else asks the user for a new one.
        /// </summary>
        /// <returns>Operation, the operation the user inserted.</returns>
        private static Operation GetAOperation()
        {
            Console.WriteLine("Please write a operation: (+, -, *, /)");
            var strVal = Console.ReadLine();

            if (OperationExtension.TryParse(strVal, out Operation operation))
            {
                return operation;
            }
            else
            {
                Console.WriteLine("A problem occurred while trying to read the desired operation.");
                return GetAOperation();
            }
        }

        /// <summary>
        /// Prints the title of the program.
        /// </summary>
        private static void PrintTitle()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to simple Calculator!");
            Console.ResetColor();
        }
    }
}
