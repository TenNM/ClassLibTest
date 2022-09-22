namespace ClassLibTest
{
    public abstract class Figure
    {
        public const double Eps = 0.001F;
        public const double SQRT2 = 1.41421356237F;
        public abstract double GetSquare();
        public static bool EqualWithEps(double a, double b)
        {
            return Math.Abs(a - b) < Eps;
        }
    }
}