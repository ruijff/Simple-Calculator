using Calculator.ENUMs;
using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Classes
{
    /// <summary>
    /// A simple Calculator class
    /// </summary>
    class SimpleCalculator : ICalculator
    {
        private float value1; // the first value in the calculation
        private float value2; // the second value in the calculation
        private Operation operation; // The operation in the calculation

        public SimpleCalculator()
        {
            value1 = value2 = float.NaN;
            operation = Operation.NA;
        }

        /// <summary>
        /// Method that will calculate the values.
        /// </summary>
        /// <returns>Float, returns the value after the calculations are finished.</returns>
        public bool Calculate(out float result)
        {
            result = 0.0f;

            if (float.IsNaN(value1) || float.IsNaN(value2) || operation == Operation.NA) return false;

            if (operation == Operation.Sum) result = value1 + value2;
            if (operation == Operation.Subtract) result = value1 - value2;
            if (operation == Operation.Multiply) result = value1 * value2;
            if (operation == Operation.Divide) result = value1 / value2;

            value1 = result;
            value2 = float.NaN;
            operation = Operation.NA;
            
            return true;
        }

        /// <summary>
        /// Sets the operation for the calculations.
        /// </summary>
        /// <param name="operation">Operation, operation to be saved.</param>
        /// <returns>True if the operation is saved correctly, else false.</returns>
        public bool SetOperation(Operation newOperation)
        {
            operation = newOperation;
            return true;
        }

        /// <summary>
        /// Sets the values for the calculations.
        /// </summary>
        /// <param name="val">Float, value to be saved.</param>
        /// <returns>True if the value is saved correctly, else False.</returns>
        public bool SetValue(float val)
        {
            if (float.IsNaN(value1))
            {
                value1 = val;
                return true;
            }
            else if (float.IsNaN(value2))
            {
                value2 = val;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
