using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{

    public class MathOperation
    {
        public double lineA;
        public double lineB;
        public double lineC;

       
        public double trSqr2(double lineA, double lineB, double lineC)
        {
            return (Math.Sqrt(((lineA + lineB + lineC) / 2) * (((lineA + lineB + lineC) / 2) - lineA) * (((lineA + lineB + lineC) / 2) - lineB) * (((lineA + lineB + lineC) / 2) - lineC)));
        }

       
        public void writeResult()
        {
            
            Console.WriteLine("Triangle area equals: {0:#.###} sq sm", trSqr2(lineA, lineB, lineC));
        }

    }





    class TrSqr
    {
        static void Main(string[] args)
        {
            double lineA1;
            double lineB1;
            double lineC1;
            double d1;

        Console.WriteLine("Finding area of a right triangle knowing length of 3 sides");
            Console.Write("Input catheter A lenth, sm: ");
            //string lineA1 = Console.ReadLine();
            lineA1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input catheter B lenth, sm: ");
            //string lineB1 = Console.ReadLine();
            lineB1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input hypotenuse C lenth, sm: ");
            //string lineC1 = Console.ReadLine();
            lineC1 = Convert.ToDouble(Console.ReadLine());

            d1 = (Math.Pow(lineA1, 2) + Math.Pow(lineB1, 2) - Math.Pow(lineC1, 2));

            if ( d1 == 0 )
            {
                MathOperation newOperation = new MathOperation
                { lineA = lineA1, lineB = lineB1, lineC = lineC1 };

                newOperation.writeResult();
            }

            else
                Console.WriteLine("Invalid input: triangle is not right!");



            Console.ReadLine();

        }




       
    }
}
