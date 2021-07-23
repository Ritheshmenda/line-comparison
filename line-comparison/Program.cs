using System;

namespace lineproblem
{
    class Program
    {
        static void Main(string[] args)
        {
            lineproblem Line1 = new lineproblem(1, 7, 4, 8);
            double Length1 = Line1.Linecomparison();
            lineproblem Line2 = new lineproblem(8, 4, 7, 1);
            double Length2 = Line2.Linecomparison();

            Console.WriteLine("length of line 2 =" + Length2);
            if (Length1 == Length2)
                Console.WriteLine("Result:Both lines are equal");
            else
                Console.WriteLine("Result:both lines are not equal");

        }
    }
}
