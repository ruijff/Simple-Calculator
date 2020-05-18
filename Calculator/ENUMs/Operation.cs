using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ENUMs
{
    /// <summary>
    /// This is the enum with all the possible operations the calculator can do.
    /// </summary>
    enum Operation
    {
        NA,
        Sum,
        Subtract,
        Multiply,
        Divide
    }

    /// <summary>
    /// This class works as a extension for the enum Operation
    /// </summary>
    static class OperationExtension
    {
        /// <summary>
        /// Trys to parse the input into a valid Operation.
        /// </summary>
        /// <param name="strOperation">String, value to be parsed.</param>
        /// <param name="operation">Operation, outputs the parsed operation.</param>
        /// <returns>True if the parsing is successful, else False.</returns>
        public static bool TryParse(string strOperation, out Operation operation)
        {
            if (strOperation == "+")
            {
                operation = Operation.Sum; return true;
            }
            else if (strOperation == "-")
            {
                operation = Operation.Subtract; return true;
            }
            else if (strOperation == "*")
            {
                operation = Operation.Multiply; return true;
            }
            else if (strOperation == "/")
            {
                operation = Operation.Divide; return true;
            }
            else
            {
                operation = Operation.NA;
                return false;
            }
        }
    }
}
