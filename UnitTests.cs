using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibTest.Tests
{
    [TestClass()]
    public class TestsTriangle
    {
        [TestMethod()]
        public void GetSquare_Triangle_2_2_2()
        {
            //arrange
            double a = 2;
            double b = 2;
            double c = 2;
            double expected = 1.7320508075688772;

            //act
            Triangle t = new Triangle(a, b, c);
            double actual = t.GetSquare();

            //assert
            Assert.IsTrue(Figure.EqualWithEps(expected, actual));
        }
    }

    [TestClass()]
    public class TestsCircle
    {
        [TestMethod()]
        public void GetSquare_Circle_1()
        {
            //arrange
            double r = 1;
            double expected = Math.PI;

            //act
            Circle c = new Circle();
            double actual = c.GetSquare();

            //assert
            Assert.IsTrue(Figure.EqualWithEps(expected, actual));
        }
    }
}