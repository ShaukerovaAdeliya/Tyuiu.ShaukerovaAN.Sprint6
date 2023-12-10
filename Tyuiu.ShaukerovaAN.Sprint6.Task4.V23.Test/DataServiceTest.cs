using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaukerovaAN.Sprint6.Task4.V23.Lib;
using System.IO;

namespace Tyuiu.ShaukerovaAN.Sprint6.Task4.V23.Test
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

            WaitArray[0] = -15.40;
            WaitArray[1] = 11.87;
            WaitArray[2] = 9.87;
            WaitArray[3] = 7.74;
            WaitArray[4] = 5.36;
            WaitArray[5] = 2.5;
            WaitArray[6] = 0.00;
            WaitArray[7] = 0.79;
            WaitArray[8] = -1.75;
            WaitArray[9] = -3.78;
            WaitArray[10] = -5.71;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(WaitArray, res);

        }
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\shauk\source\repos\Tyuiu.ShaukerovaAN.Sprint6\Tyuiu.ShaukerovaAN.Sprint6.Task4.V23\bin\Debug\OutPutFileTask4V23.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}