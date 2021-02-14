namespace Calculator.Core.Repositories
{
    public interface ICalculator
    {
        string Calculate(double dblResultValue, string strResult, string OperationPerformed);
    }
}
