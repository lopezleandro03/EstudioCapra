using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstudioCapra.Backend;


namespace EstudioCapra.Test
{
    [TestClass]
    public class UnitOfWorkTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IUnitOfWork work = new UnitOfWork();
            var clientes = work.ClienteRepository.GetAll();
            var servicios = work.ServicioRepository.GetAll();

            Assert.IsNotNull(servicios);
        }
    }
}
