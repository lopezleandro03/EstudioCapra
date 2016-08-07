using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EstudioCapra.Test
{
    [TestClass]
    public class TareaTest
    {
        [TestMethod]
        public void GetAllTareasTest()
        {
            var work = new Backend.UnitOfWork();
            var et = work.EtapaTareaRepository.GetAll();

            Assert.IsNotNull(et);
        }
    }
}
