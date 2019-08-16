namespace ObjectOrientedProgramming
{
    class Vehicles
    {
    
    }
    class Vehicle
    {
        private string make;
        private string model;
        private string year;

        protected string Make { get => make; set => make = value; }
        protected string Model { get => model; set => model = value; }
        protected string Year { get => year; set => year = value; }

        //public Vehicle()
        //{

        //}
        public Vehicle(string make, string model, string year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public void Accelerate()
        {

        }
        public void Decelerate()
        {

        }
        public void Drive()
        {

        }
        public void Start()
        {

        }
        public void Stop()
        {

        }
    }
    class Car : Vehicle
    {
        public Car(string make, string model, string year) : base(make, model, year)
        {

        }
    }
    class Sportscar : Car
    {
        public Sportscar(string make, string model, string year) : base(make, model, year)
        {

        }
    }
    class Van : Vehicle
    {
        public Van(string make, string model, string year) : base(make, model, year)
        {

        }
    }
    class ExcursionVan : Van
    {
        public ExcursionVan(string make, string model, string year) : base(make, model, year)
        {

        }
    }
    class MiniVan : Van
    {
        private bool cargoNet;
        private bool dualSlidingDoors;

        protected bool CargoNet { get => cargoNet; set => cargoNet = value; }
        protected bool DualSlidingDoors { get => dualSlidingDoors; set => dualSlidingDoors = value; }

        public MiniVan(bool cargoNet, bool dualSlidingDoors, string make, string model, string year) : base(make, model, year)
        {

        }
    }
}
