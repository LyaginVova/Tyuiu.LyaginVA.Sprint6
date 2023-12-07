using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LyaginVA.Sprint6.Task6.V30.Lib;

namespace Tyuiu.LyaginVA.Sprint6.Task6.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            var dataService = new DataService();
            var path = @"C:\Users\vova\source\repos\Tyuiu.LyaginVA.Sprint6\Tyuiu.LyaginVA.Sprint6.Task6.V30\bin\Debug\InPutFileTask6V30.txt"; 
            var result = dataService.CollectTextFromFile(path);

            Assert.AreEqual("PAlR qdsTS zgGQ XVZeHq dwMQ ", result);




        }
    }
}
