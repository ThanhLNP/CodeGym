using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgramming
{
    class Vector
    {
        public static void Main()
        {
            Vector2D v2d = new Vector2D();
            v2d.Nhap();

            Vector3D v3d = new Vector3D();
            v3d.Nhap();

            Vector3D sum = v3d.Cong(v3d, v3d.EpKieu(v2d));
            sum.Xuat();
        }
    }

    class Vector2D
    {
        private string name;
        private int x;
        private int y;

        public string Name { get => name; set => name = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Vector2D()
        {

        }

        public Vector2D(string name, int[] point)
        {
            Name = name;
            X = point[0];
            Y = point[1];
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap ten vector: ");
            name = Console.ReadLine();
            Console.Write("Nhap hoanh do x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap tung do y: ");
            y = int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("{0}({1}, {2})", name, x, y);
        }
    }

    class Vector3D : Vector2D
    {
        private int z;

        public int Z { get => z; set => z = value; }

        public Vector3D() : base()
        {

        }

        public Vector3D(string name, int[] point) : base(name, point)
        {
            Z = point[2];
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap cao do z: ");
            z = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            Console.WriteLine("{0}({1}, {2}, {3})", Name, X, Y, Z);
        }

        public Vector3D Cong(Vector3D v1, Vector3D v2)
        {
            return new Vector3D()
            {
                Name = v1.Name + v2.Name,
                X = v1.X + v2.X,
                Y = v1.Y + v2.Y,
                Z = v1.Z + v2.Z
            };
        }

        public Vector3D EpKieu(Vector2D v2d)
        {
            return new Vector3D()
            {
                Name = v2d.Name,
                X = v2d.X,
                Y = v2d.Y,
                Z = 0
            };
        }
    }
}