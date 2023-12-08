using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShaukerovaAN.Sprint6.Task5.V17.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint6.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\shauk\source\repos\Tyuiu.ShaukerovaAN.Sprint6\Tyuiu.ShaukerovaAN.Sprint6.Task5.V17\bin\Debug\InPutFileTask5V17.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
