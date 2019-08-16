namespace ObjectOrientedProgramming
{
    class Square : Shape
    {
        Location l = new Location();

        public Square(double x, double y, double side)
        {
            l.X = x;
            l.Y = y;
            l.Side = side;
        }
        public void Move(double x, double y)
        {
            l.X = x;
            l.Y = y;
        }
        public void Scale(int factor)
        {
            l.Side = l.Side * factor;
        }
        public override string ToString()
        {
            return "Corner (" + l.X / 2 + "), side " + l.Side;
        }
    }
}
