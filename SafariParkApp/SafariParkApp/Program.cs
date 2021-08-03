using System;

namespace SafariParkApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Person martin = new Person("Martin", "Beard", 21);
            //Console.WriteLine(martin.GetFullName());
            //Person cathy = new Person("Cathy", "French", 35);
            //Console.WriteLine(cathy.GetFullName());
            //Console.WriteLine(cathy.Age);

            //Person nish = new Person("Nishant");
            //Person abiola = new Person("Abiola", "Kuku");

            //cathy.Age = 30;
            //Console.WriteLine($"Cathy is now {cathy.Age}");

            //var zoe = new Person("Zoe", "") { Age = 31 };

            var list = new ShoppingList() { Bread = 2, Potato = 6, Milk = 2 };

            var paula = new Person() { FirstName = "Paula", LastName = "Kendra", Age = 23 };

            Person anotherPerson;

            Point3D p = new Point3D(3, 6, 2);
            var p2 = new Point3D();
            Point3D p3;
            Point3D p4 = new Point3D(1, 7);

            Person john = new Person("John", "Doe") { Age = 20 };
            Point3D pt3D = new Point3D(5, 8, 2);
            DemoMethod(pt3D, john);
        }
        public struct Point3D
        {
            public int x;
            public int y, z;
            public Point3D(int x, int y, int z = 5)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }
        static void DemoMethod(Point3D pt, Person p)
        {
            pt.y = 1000;
            p.Age = 92;
        }
    }
}
