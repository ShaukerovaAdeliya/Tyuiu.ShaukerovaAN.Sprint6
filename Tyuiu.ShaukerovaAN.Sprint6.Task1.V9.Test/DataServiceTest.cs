using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaukerovaAN.Sprint6.Task1.V9.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint6.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] WaitArray;
            WaitArray = new double[len];

            WaitArray[0] = -19.62;
            WaitArray[1] = -17.12;
            WaitArray[2] = -18.15;
            WaitArray[3] = -63.13;
            WaitArray[4] = -24.92;
            WaitArray[5] = -5;
            WaitArray[6] = -1.46;
            WaitArray[7] = 1.57;
            WaitArray[8] = 6.38;
            WaitArray[9] = 32.78;
            WaitArray[10] = 225.11;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(WaitArray, res);

        }
    }
}