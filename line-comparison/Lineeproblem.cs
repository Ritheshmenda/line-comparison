using System;
using System.Collections.Generic;
using System.Text;

namespace lineproblem
{
    class lineproblem
    {
<<<<<<< HEAD
        int x1, x2, x3, x4, y1, y2, y3, y4;
        public lineproblem(int x1, int x2, int y1, int y2,int x3, int x4, int y3, int y4)
=======
        int x1, x2, y1, y2;
        public lineproblem(int x1, int x2, int y1, int y2)
>>>>>>> uc1-lineproblem
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
<<<<<<< HEAD
            double lengthofline = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("length of line is:"+lengthofline);
            this.x3 = x3;
            this.x4 = x4;
            this.y3 = y3;
            this.y4 = y4;
            double lengthofline_a = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("length of line a is :" + lengthofline_a);
            if (lengthofline == lengthofline_a)
                Console.WriteLine("lines are equal");
            else if (lengthofline > lengthofline_a)
                Console.WriteLine("length of line is greater");
            else
                Console.WriteLine("length of line_a is greater");

                
=======
        }
        public double Linecomparison()
        { 
            double lengthofline = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));         
            return lengthofline;
>>>>>>> uc1-lineproblem
        }
    }
}
