using PointGeometrics;

namespace PointGeometricsTests
{
    [TestClass]
    public class Point3DTests
    {
        [TestMethod]
        public void TestAdd()
        {
            // TestCase for point P1(1,2,3) and point P2(4,5,6)
            Point3D P1 = new Point3D(1, 2, 3);
            Point3D P2 = new Point3D(4, 5, 6);

            // Act
            Point3D P3 = P1.Add(P2);

            // Assert
            Assert.AreEqual(P3.X, 5, (decimal) 0.001, "Addition: The resultant coordination in X dimension is false.");
            Assert.AreEqual(P3.Y, 7, (decimal) 0.001, "Addition: The resultant coordination in Y dimension is false.");
            Assert.AreEqual(P3.Z, 9, (decimal) 0.001, "Addition: The resultant coordination in Z dimension is false.");
        }

        [TestMethod]
        public void TestSubtract()
        {
            // TestCase for point P1(1,2,3) and point P2(4,5,6)
            Point3D P1 = new Point3D(1, 2, 3);
            Point3D P2 = new Point3D(4, 5, 6);

            // Act
            Point3D P3 = P1.Substract(P2);

            // Assert
            Assert.AreEqual(P3.X, -3, (decimal)0.001, "Substraction: The resultant coordination in X dimension is false.");
            Assert.AreEqual(P3.Y, -3, (decimal)0.001, "Substraction: The resultant coordination in Y dimension is false.");
            Assert.AreEqual(P3.Z, -3, (decimal)0.001, "Substraction: The resultant coordination in Z dimension is false.");
        }

        [TestMethod]
        public void TestMultiply()
        {
            // TestCase for point P1(1,2,3) and k = 5;
            Point3D P1 = new Point3D(1, 2, 3);
            decimal k = 5;

            // Act
            Point3D P3 = P1.Multiply(k);

            // Assert
            Assert.AreEqual(P3.X,  5, (decimal)0.001, "Multiplication: The resultant coordination in X dimension is false.");
            Assert.AreEqual(P3.Y, 10, (decimal)0.001, "Multiplication: The resultant coordination in Y dimension is false.");
            Assert.AreEqual(P3.Z, 15, (decimal)0.001, "Multiplication: The resultant coordination in Z dimension is false.");
        }

        [TestMethod]
        public void TestDivision()
        {
            // TestCase for point P1(1,2,3) and k = 10;
            Point3D P1 = new Point3D(1, 2, 3);
            decimal k = 10;

            // Act
            Point3D P3 = P1.Divide(10);

            // Assert
            Assert.AreEqual(P3.X, (decimal) 0.1, (decimal)0.001, "Division: The resultant coordination in X dimension is false.");
            Assert.AreEqual(P3.Y, (decimal) 0.2, (decimal)0.001, "Division: The resultant coordination in Y dimension is false.");
            Assert.AreEqual(P3.Z, (decimal) 0.3, (decimal)0.001, "Division: The resultant coordination in Z dimension is false.");
        }

        [TestMethod]
        public void TestComputeDistance()
        {
            // TestCase for distance between point P1(1,2,3) and point P2(4,5,6);
            Point3D P1 = new Point3D(1, 2, 3);
            Point3D P2 = new Point3D(4, 5, 6);

            // Act
            decimal distance = P1.ComputeDistance(P2);

            // Assert
            Assert.AreEqual(distance, (decimal) 5.1962, (decimal)0.001, "Multiplication: The resultant distance is false.");
        }
    }
}