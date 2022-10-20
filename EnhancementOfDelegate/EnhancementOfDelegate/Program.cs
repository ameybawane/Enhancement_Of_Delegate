using System;

/*
 * Mahesh has suggested that we should define one function called 
 * PerformArithmeticOperation( ) which will take 2 numbers and the 
 * Delegate as parameters. Instead of calling / executing the 
 * delegate from Main() function, let this function manage the 
 * delegate call. You have to implement this functionality.
 * 
 * Hint: The PerformArithmeticOperation() function signature is:
 * 
 * static void PerformArithmeticOperation( int num1, int num2, MyDelegate arOperation){…}
 */
namespace EnhancementOfDelegate
{
    internal class Program
    {
        delegate int MyDelegate(int num1, int num2);
        static void Main(string[] args)
        {
            MyDelegate arOperation = (int num1, int num2) => num1 + num2;
            PerformArithmeticOperation(5, 9, arOperation);

            Console.ReadKey();
        }
        static void PerformArithmeticOperation(int num1, int num2, MyDelegate arOperation)
        {
            var result = arOperation(num1, num2);
            Console.WriteLine(result);
        }
    }
}
