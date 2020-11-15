using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleType
{
    public class Triangle
    {
        /// <summary>
        /// Takes in three inputs and checks if any are less than 1 if so it is not a triangle, next we check if they are all equal, then 
        /// check if two are equal if none of these are valid then the triangle is scalene
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
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
