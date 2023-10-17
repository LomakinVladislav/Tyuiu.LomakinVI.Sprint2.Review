using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint2.TaskReview.V12.Lib;

namespace Tyuiu.LomakinVI.Sprint2.TaskReview.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = -2.5;
            double y = 4.3;
            bool wait = false;

            Assert.AreEqual(wait, ds.CheckDotInShadedArea(x, y));
        }
    }
}
