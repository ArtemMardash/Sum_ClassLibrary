using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sum_ClassLibrary;

namespace UnitTestProject_Sum
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum_for100_to500_returned120300()
        {
            Class1 class1 = new Class1();
            string expected = "120300";
            string actual = class1.summ(100,500);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_for0_to0_returned0()
        {
            Class1 class1 = new Class1();
            string expected = "0";
            string actual = class1.summ(0,0);
            Assert.AreEqual(expected , actual);
        }
        [TestMethod]
        public void Sum_for0_toNegative10_returnedIf()
        {
            Class1 class1 = new Class1();
            string ecpected = "b must be more or equal than a";
            string actual = class1.summ(0, -10);
            Assert.AreEqual(ecpected, actual);
        }
        [TestMethod]
        public void Sum_for5_to5_returned5()
        {
            Class1 class1 = new Class1();
            string expected  = "5";
            string actual = class1.summ(5, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sum_forNegative10_to11_returned11()
        {
            Class1 class1 = new Class1();
            string expected = "11";
            string actual = class1.summ(-10, 11);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] 
        public void Mult_for1_to5_return120()
        {
            Class1 class1 = new Class1();
            string expected = "120";
            string actual = class1.Multiply(1, 5);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Mult_for0_to100_return0()
        {
            Class1 class1 = new Class1();
            string expected = "0";
            string actual = class1.Multiply(0, 100);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Mult_forNegative5_toNegative1_returnNegative120()
        {
            Class1 class1 = new Class1();
            string expected = "-120";
            string actual = class1.Multiply(-5, -1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Mult_ForNegative2_toNegative1_return2()
        {
            Class1 class1 = new Class1();
            string expected = "2";
            string actual = class1.Multiply(-2, -1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Mult_forNegative10_to11_return()
        {
            Class1 class1 =  new Class1();
            string expected = "0";
            string actual = class1.Multiply(-10, 11);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumSr_for1_to3_return2()
        {
            Class1 class1 = new Class1();
            string expected = "2";
            string actual = class1.srArf(1, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumSr_forNegative2_to2_return0()
        {
            Class1 class1 = new Class1();
            string expected = "0";
            string actual = class1.srArf(-2, 2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumSr_for0_to0_return0()
        {
            Class1 class1 = new Class1();
            string expected = "0";
            string actual = class1.srArf(0, 0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumSr_for10_to9_returnIf()
        {
            Class1 class1 = new Class1();
            string expected = "b must be more than a";
            string actual = class1.srArf(10, 9);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumSr_forNegative3_to0_returnEx()
        {
            Class1 class1 = new Class1();
            string expected = "-1,5";
            string actual = class1.srArf(-3, 0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumCube_for1_to3_return36()
        {
            Class1 class1 = new Class1();
            string expected = "36";
            string actual = class1.SumOfCube(1, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumCube_forNegative2_to2_return0()
        {
            Class1 class1 = new Class1();
            string expected = "0";
            string actual = class1.SumOfCube(-2, 2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumCube_forNegative3_to0_returnNegative36()
        {
            Class1 class1 = new Class1();
            string expected = "-36";
            string actual = class1.SumOfCube(-3, 0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumCube_for3_toO_returnIf()
        {
            Class1 class1 = new Class1();
            string expected = "b must be more than a";
            string actual = class1.SumOfCube(3, 0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumCube_for0_to0_return0()
        {
            Class1 class1 = new Class1();
            string expected = "0";
            string actual = class1.SumOfCube(0, 0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumQuadrat_for3_to5_return50()
        {
            Class1 class1 = new Class1();
            string expected = "50";
            string actual = class1.SumOfQuadrt(3, 5);
            Assert.AreEqual(expected, actual); 
        }
        [TestMethod]
        public void SumQuadrat_for0_to0_return0()
        {
            Class1 class1 = new Class1();
            string expected = "0";
            string actual = class1.SumOfQuadrt(0, 0);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumQuadrant_forNegative3_to5_return69()
        {
            Class1 class1 = new Class1();
            string expected = "69";
            string actual = class1.SumOfQuadrt(-3, 5);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumQuadrant_forNegative5_toNegative3_return50()
        {
            Class1 class1 = new Class1();
            string expected = "50";
            string actual = class1.SumOfQuadrt(-5, -3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumQuadrant_for10_to0_returnIF()
        {
            Class1 class1 = new Class1();
            string expected = "b must be more than a";
            string actual = class1.SumOfQuadrt(10, 0);
            Assert.AreEqual(expected, actual);
        }
    }
}
