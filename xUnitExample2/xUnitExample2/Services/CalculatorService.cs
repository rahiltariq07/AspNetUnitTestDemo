namespace xUnitExample2.Services
{
    public class CalculatorService
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
            //=> x + y;
        public int Divide(int x, int y)
        {
            if (y == 0) throw new ArgumentException("Cannot divide by zero");
            return x / y;
        }
    }
}
