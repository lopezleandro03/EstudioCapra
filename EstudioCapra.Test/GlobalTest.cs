using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstudioCapra.Backend;
using Common;

namespace EstudioCapra.Test
{
    [TestClass]
    public class GlobalTest
    {
        [TestMethod]
        public void TestGetConnString()
        {
            var cnnStr = DbConnectionUtitly.GetADONetConnectionString() ;
            Assert.IsNotNull(cnnStr);
        }
    }
}
