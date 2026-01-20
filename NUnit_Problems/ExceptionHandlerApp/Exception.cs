using System;

namespace ExceptionHandlerApp
{
    public class ExceptionService
    {
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new ArithmeticException("Divide by zero");
            return a / b;
        }
    }
}
