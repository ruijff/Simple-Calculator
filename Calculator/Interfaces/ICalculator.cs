using Calculator.ENUMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    /// <summary>
    /// The base interface for a calculator.
    /// </summary>
    interface ICalculator
    {
        /// <summary>
        /// Method that will calculate the values.
        /// </summary>
        /// <param name="result">Float, outputs the value after the calculations are finished.</param>
        /// <returns>True if the calculations ran without problems, else False.</returns>
        bool Calculate(out float result);

        /// <summary>
        /// Sets the values for the calculations.
        /// </summary>
        /// <param name="val">Float, value to be saved.</param>
        /// <returns>True if the value is saved correctly, else False.</returns>
        bool SetValue(float val);

        /// <summary>
        /// Sets the operation for the calculations.
        /// </summary>
        /// <param name="operation">Operation, operation to be saved.</param>
        /// <returns>True if the operation is saved correctly, else false.</returns>
        bool SetOperation(Operation operation);
    }
}
