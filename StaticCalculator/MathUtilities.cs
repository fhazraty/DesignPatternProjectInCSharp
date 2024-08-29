namespace StaticCalculator
{
    public static class MathUtilities
    {
        public static int OperationCounter = 0;

        public static int Add(int a,int b)
        {
            OperationCounter++;
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            OperationCounter++;
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            OperationCounter++;
            return a * b;
        }
        public static int Devide(int a, int b)
        {
            OperationCounter++;
            return a / b;
        }
    }
}
