using System;
using TriangleType;
using Xunit;

namespace TriangleTests
{
    public class TriangleTests
    {

        Triangle tr = new Triangle();


        [Fact]
        public void TestEquilateral()
        {

            string output = tr.TriangleType(3, 3, 3);

            if (output == "The traingle is equilateral")
            {
                Assert.True(true);            
            }
            else
                Assert.True(false);


        }

        [Fact]
        public void TestNegative()
        {
          string output = tr.TriangleType(-2, 3, 3);

            if (output == "Triangles need lengths greater than 0")
            {
                Assert.True(true);
            }
            else
                Assert.True(false);

        }


        [Fact]
        public void TestIsosceles()
        {
            string output = tr.TriangleType(3, 3, 4);

            if (output == "The traingle is Isosceles")
            {
                Assert.True(true);
            }
            else
                Assert.True(false);

        }


        

            [Fact]
        public void TestScalene()
        {
            string output = tr.TriangleType(3, 2 , 4);

            if (output == "The triangle is Scalene")
            {
                Assert.True(true);
            }
            else
                Assert.True(false);

        }


    }
}
