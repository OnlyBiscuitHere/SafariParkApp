using NUnit.Framework;
using SafariParkApp;

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
    }
}