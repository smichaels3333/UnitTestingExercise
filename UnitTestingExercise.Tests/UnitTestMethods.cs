using System;

namespace UnitTestingExercise.Tests
{
    public class UnitTestMethods
    {
        public UnitTestMethods()
        {
        }

        public int Add(int one, int two, int three)
        {
            return one + two + three;
        }

        public int Subtract(int minuend, int subtrhend)
        {
            return minuend- subtrhend;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Divide(int num1, int num2) 
        {
            return num1 / num2;
        }
    }
}