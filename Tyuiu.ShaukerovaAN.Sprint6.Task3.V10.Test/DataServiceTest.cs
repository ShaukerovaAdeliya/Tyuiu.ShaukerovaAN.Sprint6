using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaukerovaAN.Sprint6.Task3.V10.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint6.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] valueArray = { { -17, 6, -19, 6, -13 },
                { -19, 3, 12, -11, 19 },
                { -20, 11, 9, 19, -19 },
                { -20, 10, -9, 17, 9 },
                { -4, 9, -8, 13, -8 }, };
            int[,] res = ds.Calculate(valueArray);

            int[,] wait = { { -17, 6, -19, 6, -13 },
                { -19, 3, 12, -11, 19 },
                { -20, 11, 9, 19, -19 },
                { -20, 10, -9, 17, 9 },
                { 0, 9, 0, 13, 0 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
