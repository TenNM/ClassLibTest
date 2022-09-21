namespace ClassLibTest
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 1;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetSquare()
        {
            return Pi * Radius * Radius;
        }
    }
}
