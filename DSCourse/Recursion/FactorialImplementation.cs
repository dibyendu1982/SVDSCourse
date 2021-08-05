using System;

namespace DSCourse.Recursion
{
    public class FactorialImplementation
    {
        public int RecursiveFactorial(int n)
        {
            return n == 0 ?  1 : n* RecursiveFactorial(n -1);
        }

        public int NonRecursiveFactorial(int n)
        {
            var result = 1;
            for (var i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

    }
}