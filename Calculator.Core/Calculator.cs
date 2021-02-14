using System;

namespace Calculator.Core.Repositories
{
    public class Calculator : ICalculator
    {
        /// <summary>
        /// Performs the the Addition function by adding dblResultValue which is the first value and strResult which 
        /// is the value to be added as a paremeters and returns the answer as string.
        /// </summary>
        /// <param name="dblResultValue"></param>
        /// <param name="strResult"></param>
        /// <returns></returns>
        private string Add(double dblResultValue, string strResult)
        {
            return (dblResultValue + Double.Parse(strResult)).ToString();
        }

        /// <summary>
        /// Performs the the Minus function by minusing dblResultValue which is the first value and strResult which
        /// is the value to be minused as a paremeters and returns the answer as string.
        /// </summary>
        /// <param name="dblResultValue"></param>
        /// <param name="strResult"></param>
        /// <returns></returns>
        private string Minus(double dblResultValue, string strResult)
        {
            return (dblResultValue - Double.Parse(strResult)).ToString();
        }

        /// <summary>
        /// Performs the the Multiplication function by multiplying dblResultValue which is the first value and strResult which
        /// is the value to be multiplied as a paremeters and returns the answer as string.
        /// </summary>
        /// <param name="dblResultValue"></param>
        /// <param name="strResult"></param>
        /// <returns></returns>
        private string Multiply(double dblResultValue, string strResult)
        {
            return (dblResultValue * Double.Parse(strResult)).ToString();
        }

        /// <summary>
        /// Performs the the Divide function by dividing dblResultValue which is the first value and strResult which
        /// is the value to be divided as a paremeters and returns the answer as string.
        /// </summary>
        /// <param name="dblResultValue"></param>
        /// <param name="strResult"></param>
        /// <returns></returns>
        private string Divide(double dblResultValue, string strResult)
        {
            return (dblResultValue / Double.Parse(strResult)).ToString();
        }

        /// <summary>
        /// This performs the Addition, Minus, Multiply and Division functions determined my the operation parsed and 
        /// returns the results when the functions is performed. This parses dblResultValue as the first value, strResult as the second value
        /// and the operation that performs the operations.
        /// </summary>
        /// <param name="dblResultValue"></param>
        /// <param name="strResult"></param>
        /// <param name="OperationPerformed"></param>
        /// <returns></returns>
        public string Calculate(double dblResultValue, string strResult, string OperationPerformed)
        {
            switch (OperationPerformed)
            {
                case "+":
                    strResult = Add(dblResultValue, strResult);
                    break;
                case "-":
                    strResult = Minus(dblResultValue, strResult);
                    break;
                case "*":
                    strResult = Multiply(dblResultValue, strResult);
                    break;
                case "/":
                    strResult = Divide(dblResultValue, strResult);
                    break;
                default:
                    strResult = "Invalid Operation";
                    break;
            }
            return strResult;
        }

    }
}
