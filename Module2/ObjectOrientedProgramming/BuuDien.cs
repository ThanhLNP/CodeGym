namespace ObjectOrientedProgramming
{
    class BuuDien
    {

    }

    abstract class BuuPham
    {
        private string address;
        private string customer;

        public string Address { get => address; set => address = value; }
        public string Customer { get => customer; set => customer = value; }

        public BuuPham()
        {

        }

        public BuuPham(string address, string customer)
        {
            Address = address;
            Customer = customer;
        }

        public abstract float ChiPhi();
    }

    class HangHoa : BuuPham
    {
        private float weight;

        public float Weight { get => weight; set => weight = value; }

        public HangHoa()
        {

        }

        public HangHoa(string address, string customer, float weight) : base(address, customer)
        {
            Weight = weight;
        }

        public override float ChiPhi()
        {
            return 10000 * weight;
        }
    }

    class Thu : BuuPham
    {
        private bool categorize;

        public bool Categorize { get => categorize; set => categorize = value; }

        public Thu()
        {

        }

        public Thu(string address, string customer, bool categorize) :base(address, customer)
        {
            Categorize = categorize;
        }

        public override float ChiPhi()
        {
            if (categorize)
                return 3000;
            else
                return 500;
        }
    }
}