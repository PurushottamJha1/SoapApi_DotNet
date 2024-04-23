using Microsoft.AspNetCore.Http.HttpResults;
using System.ServiceModel;

namespace SoapApi.MyMathsCalculator
{


    [ServiceContract]
    public interface ISoapService
    {
        [OperationContract]
        string Sum(int num1, int num2);
        [OperationContract]
        string Multiply(int num1, int num2);
        [OperationContract]
        string Subtract(int num1, int num2);
        [OperationContract]

        string Divide(int num1, int num2);
    }

    public class MathsSoapService : ISoapService
    {
        public string Sum(int num1, int num2)
        {
            return $"Sum of two number is: {num1 + num2}";
        }
        public string Multiply(int num1, int num2)
        {
            return $"Multiply of two number is: {num1 * num2}";
        }
        public string Divide(int num1, int num2)
        {
            if (num2 == 0) { return "Invalid"; }
            return $"Division of two number is: {num1 / num2}";
        }
        public string Subtract(int num1, int num2)
        {
            return $"Subtraction of two number is: {num1 - num2}";
        }

    }
}

