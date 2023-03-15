using QuadraticEquation;
using QuadraticEquationForm;

namespace QuadraticEquationTest
{

    [TestClass]
    public class Test_QuQuadEq
    {
        [TestMethod]
        public void Test_Calculate_D_lesser_than_0()
        {
            // Arrange.
            QuadEq test1 = new QuadEq(1, 2, 3);
            QuadEq test2 = new QuadEq(-33, 5.23, -3);
            QuadEq test3 = new QuadEq(42, 40, 42);

            // Act.
            test1.Calculate();
            test2.Calculate();
            test3.Calculate();

            // Assert.
            Assert.IsTrue(test1.D < 0);
            Assert.IsTrue(test2.D < 0);
            Assert.IsTrue(test3.D < 0);
        }

        [TestMethod]
        public void Test_Calculate_D_equals_0()
        {
            // Arrange.
            QuadEq test1 = new QuadEq(4, 8, 4);
            QuadEq test2 = new QuadEq(-2.25, 4.5, -2.25);
            QuadEq test3 = new QuadEq(1, 12, 36);

            // Act.
            test1.Calculate();
            test2.Calculate();
            test3.Calculate();

            // Assert.
            Assert.AreEqual(0, test1.D, 0.1);
            Assert.AreEqual(test1.X1, test1.X2);

            Assert.AreEqual(0, test2.D, 0.1);
            Assert.AreEqual(test2.X1, test2.X2);

            Assert.AreEqual(0, test3.D, 0.1);
            Assert.AreEqual(test3.X1, test3.X2);

        }

        [TestMethod]
        public void Test_Calculate_D_greater_than_0()
        {
            // Arrange.
            QuadEq test1 = new QuadEq(1, 5, 3);
            QuadEq test2 = new QuadEq(-33, 15.23, 3);
            QuadEq test3 = new QuadEq(42, 40, -42);
            double d;
            double test1_x1, test1_x2;
            double test2_x1, test2_x2;
            double test3_x1, test3_x2;

            // Act.
            d = test1.B * test1.B - 4 * test1.A * test1.C;
            test1_x1 = (-test1.B + Math.Sqrt(d)) / (2 * test1.A);
            test1_x2 = (-test1.B - Math.Sqrt(d)) / (2 * test1.A);
            test1.Calculate();

            d = test2.B * test2.B - 4 * test2.A * test2.C;
            test2_x1 = (-test2.B + Math.Sqrt(d)) / (2 * test2.A);
            test2_x2 = (-test2.B - Math.Sqrt(d)) / (2 * test2.A);
            test2.Calculate();


            d = test3.B * test3.B - 4 * test3.A * test3.C;
            test3_x1 = (-test3.B + Math.Sqrt(d)) / (2 * test3.A);
            test3_x2 = (-test3.B - Math.Sqrt(d)) / (2 * test3.A);
            test3.Calculate();

            // Assert.
            Assert.IsTrue(test1.D > 0);
            Assert.AreEqual(test1.X1, test1_x1, 0.000001);
            Assert.AreEqual(test1.X2, test1_x2, 0.000001);

            Assert.IsTrue(test2.D > 0);
            Assert.AreEqual(test2.X1, test2_x1, 0.000001);
            Assert.AreEqual(test2.X2, test2_x2, 0.000001);

            Assert.IsTrue(test3.D > 0);
            Assert.AreEqual(test3.X1, test3_x1, 0.000001);
            Assert.AreEqual(test3.X2, test3_x2, 0.000001);
        }

        [TestMethod]
        public void Test_Not_Quadratic()
        {
            // Arrange.
            string exceptionText = "You entered not a quadratic equation";
            QuadEq test1 = new QuadEq(0, 5, 3);
            QuadEq test2 = new QuadEq(0, 15.23, 3);
            QuadEq test3 = new QuadEq(0, 40, -42);

            // Act.
            try
            {
                test1.Calculate();
            }
            // Assert.
            catch (Exception ex) { Assert.AreEqual(ex.Message, exceptionText); }

            // Act.
            try
            {
                test2.Calculate();
            }
            // Assert.
            catch (Exception ex) { Assert.AreEqual(ex.Message, exceptionText); }

            // Act.
            try
            {
                test3.Calculate();
            }
            // Assert.
            catch (Exception ex) { Assert.AreEqual(ex.Message, exceptionText); }
        }
    }
}