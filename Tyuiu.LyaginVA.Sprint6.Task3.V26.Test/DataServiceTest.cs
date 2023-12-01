using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LyaginVA.Sprint6.Task3.V26.Lib;

namespace Tyuiu.LyaginVA.Sprint6.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 16, 19, 17, 2, 8 },
                                            { -17, 8, -17, -8, 1 },
                                            { -7, 17, -2, 1, -3 },
                                            { -12, 0, -17, 15, 6 },
                                            { 17, -6, -17, 18, -19 } };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[5, 5] { { 16, 19, 17, 2, 8 },
                                            { -17, 8, -17, -8, 1 },
                                            { -7, 17, 0, 1, -3 },
                                            { -12, 0, -17, 15, 6 },
                                            { 17, -6, -17, 18, -19 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
