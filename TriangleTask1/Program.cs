using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTask1
{

    class Program
    {
        public class point
        {
            public int x, y;

            public point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        };

        static double euclidDistSquare(point p1,
            point p2)
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) +
                             Math.Pow(p1.y - p2.y, 2));
        }

        static string isEquilateral(double a, double b, double c)
        {
            if (a == b && b == c && a == c)
            {
                return "Triangle IS 'Equilateral' ";
            }
            else
            {
                return "Triangle IS NOT 'Equilateral' ";
            }
               
        }

        static string isIsosceles(double a, double b, double c)
        {
            if (a == b || b == c || a==c)
            {
                return "Triangle IS 'Isosceles'";
            }
            else
            {
                return "Triangle IS NOT 'Isosceles'";
            }
                
        }

        static string isRight(double a, double b, double c)
        {
            double delta = 0.0001;
            if (Math.Abs(Math.Pow(b,2)-(Math.Pow(a,2)+Math.Pow(c,2))) <= delta ||
                Math.Abs(Math.Pow(c,2)-(Math.Pow(b,2)+Math.Pow(a,2))) <= delta || 
                Math.Abs(Math.Pow(a,2)-(Math.Pow(b,2)+Math.Pow(c,2))) <= delta)
            {
                return "Triangle IS 'Right'";
            }
            else
            {
                return "Triangle IS NOT 'Right'";
            }
                
        }

        static double perimeterOfTriangle(double a, double b, double c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinate x of dot A");
            int aX = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot A");
            int aY = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot B");
            int bX = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot B");
            int bY = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot C");
            int cX = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot C");
            int cY = Int32.Parse(Console.ReadLine());

            point pA, pB, pC;

            pA = new point(aX, aY);
            pB = new point(bX, bY);
            pC = new point(cX, cY);

            Console.WriteLine("");

            double AB = euclidDistSquare(pA, pB);
            Console.WriteLine("Length of AB is: '{0}'", AB);
            double BC = euclidDistSquare(pB, pC);
            Console.WriteLine("Length of BC is: '{0}'", BC);
            double AC = euclidDistSquare(pA, pC);
            Console.WriteLine("Length of AC is: '{0}'", AC);


            string isEq = isEquilateral(AB, BC, AC);
            Console.WriteLine(isEq);

            string isIso = isIsosceles(AB, BC, AC);
            Console.WriteLine(isIso);

            string isR = isRight(AB, BC, AC);
            Console.WriteLine(isR);

            double perimeter = perimeterOfTriangle(AB, BC, AC);
            Console.WriteLine("Perimeter: '{0}'", perimeter);

            Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");

            for (int i = 0; i < perimeter; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
