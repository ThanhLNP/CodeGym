using System;

namespace ObjectOrientedProgramming
{
    public class Animals
    {
        public static void Main()
        {
            Cat conMeo = new Cat("Kitty", "Trang", 4, "Nau", "Nguyen Van A");
            conMeo.Display();

            Console.Write("Nhap ten chu nhan moi: ");
            conMeo.Boss = Console.ReadLine();
            conMeo.Display();
        }
    }
    abstract class Animal
    {
        private string name;
        private string color;
        private int leg;

        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public int Leg { get => leg; set => leg = value; }

        public Animal()
        {

        }

        public Animal(string name, string color, int leg)
        {
            Name = name;
            Color = color;
            Leg = leg;
        }

        public abstract void Fly();
    }

    class Cat : Animal
    {
        private string eyeColor;
        private string boss;

        public string EyeColor { get => eyeColor; set => eyeColor = value; }
        public string Boss { get => boss; set => boss = value; }

        public Cat()
        {

        }

        public Cat(string name, string color, int leg, string eyeColor, string boss) : base(name, color, leg)
        {
            EyeColor = eyeColor;
            Boss = boss;
        }

        public void Display()
        {
            Console.WriteLine("Meo {0} cua {1} co long mau {2}",Name, Boss, Color);
        }

        public override void Fly()
        {
            Console.WriteLine("Meo khong biet bay");
        }
    }
}