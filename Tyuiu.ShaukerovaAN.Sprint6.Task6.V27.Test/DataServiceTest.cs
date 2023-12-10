using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.ShaukerovaAN.Sprint6.Task6.V27.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint6.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\shauk\source\repos\Tyuiu.ShaukerovaAN.Sprint6\InPutFileTask6V27.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "UpGwjzkBH OHcr KgepHrKCHa";
            Assert.AreEqual(wait, res);
        }
    }
}
