namespace ObjectOrientedProgramming
{
    class Shapes
    {
       
    }
    class Shape
    {
        protected Location c;
        public override string ToString()
        {
            return "";
        }
        public double Area()
        {
            return 0.0;
        }
        public double Perimeter()
        {
            return 0.0;
        }
    }
    class Location
    {
        private double x, y, side;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Side { get => side; set => side = value; }
    }
    class Rectangle : Shape
    {
        protected double side2;
        protected double side1;

        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }
    }
    class Circle : Shape
    {
        protected double radius;

        public double Radius { get => radius; set => radius = value; }
    }
}
