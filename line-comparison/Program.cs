using System;

namespace lineproblem
{
    class Program
    {
        static void Main(string[] args)
        {
                             
            lineproblem Line1 = new lineproblem(1, 7, 4, 8);
            double Length1 = Line1.Linecomparison();
            lineproblem Line2 = new lineproblem(1, 7, 4,8);
            double Length2 = Line2.Linecomparison();
            Console.WriteLine("length of line 1 =" + Length1);
            Console.WriteLine("length of line 2 =" + Length2);
            if (Length1 == Length2)
            {
                Console.WriteLine("Result:Both lines are equal");
            }
            else if (Length1 < Length2)
            {
                Console.WriteLine("Result:line 1 is less then line2");
                
            }
            else
            {
                Console.WriteLine("Result:length1 is not equal to length2");
               
            }

        }
    }
}
