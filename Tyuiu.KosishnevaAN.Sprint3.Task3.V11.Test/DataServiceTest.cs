using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosishnevaAN.Sprint3.Task3.V11.Lib;
namespace Tyuiu.KosishnevaAN.Sprint3.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();
            string str = "sqwreq vqwqq q";
            char replaceable = 'q';
            char replacement = '7';
            string res = ds.ReplaceCharOnNum(str, replaceable, replacement);
            string wait = "s7wre7 v7w77 7";
            Assert.AreEqual(wait, res);
        }
    }
}
