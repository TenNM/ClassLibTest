namespace ClassLibTest
{
    public class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle()
        {
            SideA = 1;
            SideB = 1;
            SideC = SQRT2;
        }
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double GetSquare()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public bool IsRectangular()
        {
            return IsRectangular(SideA, SideB, SideC)
                || IsRectangular(SideA, SideC, SideB)
                || IsRectangular(SideB, SideC, SideA);
        }
        public static bool IsRectangular(double cathetus1, double cathetus2, double hypotenuse)
        {
            return Math.Abs(Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2) - Math.Pow(hypotenuse, 2)) < Eps;
        }
    }
}
