using System;
using ConsoleApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jni4NetTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestAdd()
        {
            Program p = new Program();
            //using (Program p = new Program())
            { 
                Assert.AreEqual(5, p.Add(2, 3));
            }
        }

        [TestMethod]
        public void TestSub()
        {
            Program p = new Program();
            //using ()
            {
                Assert.AreEqual(7, p.Sub(10, 3));
            }
        }
    }
}
