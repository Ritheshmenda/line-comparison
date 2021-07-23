using System;

namespace lineproblem
{
    class Program
    {
        static void Main(string[] args)
        {
            lineproblem Line1 = new lineproblem(1,7,4,8);
            double Length1 = Line1.Linecomparison();
            Console.WriteLine("length of line 1 =" + Length1);

        }
    }
}
