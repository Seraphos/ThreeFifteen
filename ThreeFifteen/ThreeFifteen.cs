using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Object.

namespace ThreeFifteen
{
    class ThreeFifteen
    {
        static void Main(string[] args)
        {

            int test1, test2, test3, sum, product, difference, quotient;
            Console.WriteLine("Please enter the first integer (test1): ");
            test1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second integer (test2): ");
            test2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the third integer (test3): ");
            test3 = Convert.ToInt32(Console.ReadLine());

            //test for divide by zero
            if (test2 == 0) {
                Console.WriteLine("Cannot divide by zero.");
                Console.WriteLine("test2 replaced with a '1'.");
                test2 = 1;}

            sum = test1 + test2;
            product = test1 * test2;
            difference = test1 % test2;
            quotient = test1 / test2;
            Console.WriteLine("The sum of the two integers you entered is: {0}", sum);
            Console.WriteLine("The product of the two integers you entered is: {0}", product);
            Console.WriteLine("The difference of the two integers you entered is: {0}", difference);
            Console.WriteLine("The quotient of the two integers you entered is: {0}", quotient);

            if (test1 == test2) { Console.WriteLine("The numbers are equal.");}
            if (test1 > test2) { Console.WriteLine("{0} is the greater of the two entries.", test1); }
            if (test1 < test2) { Console.WriteLine("{0} is the lesser of the two entries.", test1); }

            if (test1 > test2 && test1 > test3)
                Console.Write("{0} is the greatest of the three integers.", test1);
            if (test1 < test2 && test2 > test3)
                Console.Write("{0} is the greatest of the three integers.", test2);
            if (test3 > test1 && test3 > test2)
            Console.Write("{0} is the greatest of the three integers.", test3);
            Console.ReadKey();
        }
    }
}
