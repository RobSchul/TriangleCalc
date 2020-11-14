using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleType
{
    public class Triangle
    {
        public  string TriangleType(int a, int b, int c)
        {

            if (a < 1 || b < 1 || c < 1) { 
                return "Triangles need lengths greater than 0";
            }
            else if (a == b && b == c)
            {
                return "The traingle is equilateral";
            }
            else if (a == b || b == c || a == c)
            {
                return "The traingle is Isosceles";
            }
            else
            {
                return "The triangle is Scalene";
            }


        }
    }
}
