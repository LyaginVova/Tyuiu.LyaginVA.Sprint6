using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.LyaginVA.Sprint6.Task5.V2.Lib;

namespace Tyuiu.LyaginVA.Sprint6.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\vova\source\repos\Tyuiu.LyaginVA.Sprint6\Tyuiu.LyaginVA.Sprint6.Task5.V2\bin\Debug\InPutFileTask5V2.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
