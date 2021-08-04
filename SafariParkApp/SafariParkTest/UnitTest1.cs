using NUnit.Framework;
using SafariParkApp;
using System;

namespace SafariParkTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Cathy", "French", "Cathy French")]
        [TestCase("", "", " ")]
        public void GetFullNameTest(string fname, string lname, string expected)
        {
            var subject = new Person(fname, lname);
            var result = subject.GetFullName();
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AgeTest()
        {
            var subject = new Person("A", "B");
            subject.Age = 35;
            Assert.AreEqual(35, subject.Age);
        }
        [TestCase(1, 1, 1, 1, 1, 1)]
        [TestCase(3, 7, 8, 3, 7, 8)]
        [TestCase(69, 420, 180, 69, 420, 180)]
        public void Point3DTest(int x, int y, int z, int expectedX, int expectedY, int expectedZ)
        {
            var subject = new Program.Point3D(x, y, z);
            Assert.AreEqual(subject.x, expectedX);
            Assert.AreEqual(subject.y, expectedY);
            Assert.AreEqual(subject.z, expectedZ);
        }
        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }
        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPosition40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }
        [Test]
        public void WhenNumPassengersExceedsCapacityThrowsException()
        {
            Vehicle v = new Vehicle(1,10);
            Assert.That(() => v.NumPassengers = 600, Throws.TypeOf<ArgumentException>());
        }
    }
}