using System;
using System.Collections.Generic;

namespace SafariParkApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //person martin = new person("martin", "beard", 21);
            //console.writeline(martin.getfullname());
            //person cathy = new person("cathy", "french", 35);
            //console.writeline(cathy.getfullname());
            //console.writeline(cathy.age);

            //person nish = new person("nishant");
            //person abiola = new person("abiola", "kuku");

            //cathy.age = 30;
            //console.writeline($"cathy is now {cathy.age}");

            //var zoe = new person("zoe", "") { age = 31 };

            //var list = new ShoppingList() { bread = 2, potato = 6, milk = 2 };

            //var paula = new person() { firstname = "paula", lastname = "kendra", age = 23 };

            //person anotherperson;

            //point3d p = new point3d(3, 6, 2);
            //var p2 = new point3d();
            //point3d p3;
            //point3d p4 = new point3d(1, 7);

            //person john = new person("john", "doe") { age = 20 };
            //point3d pt3d = new point3d(5, 8, 2);
            //demomethod(pt3d, john);

            //Hunter h = new Hunter("Marion", "Jones", "Canon") { Age = 32 };
            //Console.WriteLine(h.Age);
            //Console.WriteLine(h.Shoot());
            //Hunter h2 = new Hunter();
            //Console.WriteLine(h2.Shoot());
            //Console.WriteLine($"h Equals h2? {h.Equals(h2)}");
            //Console.WriteLine($"h HashCode: {h.GetHashCode()}");
            //Console.WriteLine($"h Type: {h.GetType()}" );
            //Console.WriteLine($"h ToString: {h.ToString()}");
            //Console.WriteLine($"h: {h}");

            //Rectangle r = new Rectangle(2, 6);
            //Console.WriteLine(r.CalculateArea());

            //Aeroplane a = new Aeroplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            //a.Ascend(500);
            //Console.WriteLine(a.Move(3));
            //Console.WriteLine(a);
            //a.Descend(200);
            //Console.WriteLine(a.Move());
            //a.Move();
            //Console.WriteLine(a) ;

            //List<object> gameObjects = new List<object>()
            //{
            //    new Person("Cathy", "French"),
            //    new Aeroplane(400, 200, "Booing") { NumPassengers = 55 },
            //    new Vehicle(12, 20) { NumPassengers = 6 },
            //    new Hunter("Henry", "Hodgkins", "Pentax")
            //};
            //foreach (var gameObj in gameObjects)
            //{
            //    Console.WriteLine(gameObj);
            //}

            //Person yolanda = new Person("Yolanda", "Young");
            //Hunter henry = new Hunter("Henry", "Hodgkins", "Pentax");
            //SpartaWrite(yolanda);
            //SpartaWrite(henry);
            //List<IMoveable> moveableObjects = new List<IMoveable>()
            //{
            //    new Person("Cathy", "French"),
            //    new Aeroplane(400, 200, "Booing") { NumPassengers = 55 },
            //    new Vehicle(12, 20) { NumPassengers = 6 },
            //    new Hunter("Henry", "Hodgkins", "Pentax")
            //};
            //foreach (var moving in moveableObjects)
            //{
            //    Console.WriteLine(moving.Move());
            //}

            Camera pentax = new Camera("Pentax");
            WaterPistol pistol = new WaterPistol("Supersoaker");
            LaserGun laserGun = new LaserGun("Acme");
            Hunter nish = new Hunter("Nish", "Mandal", pentax);
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = laserGun;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());

        }

        public static void SpartaWrite(object obj)
        {
            Console.WriteLine(obj.ToString());
            if (obj is Hunter)
            {
                var hunterObj = (Hunter)obj;
                Console.WriteLine(hunterObj.Shoot());
            }
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
        static void demomethod(Point3D pt, Person p)
        {
            pt.y = 1000;
            p.Age = 92;
        }
    }
}
