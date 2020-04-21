using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Reflection;
using Business.Concrete;
using Entities.Abstract;
using Entities.Concrete;
using log4net;
using log4net.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ValidationException = FluentValidation.ValidationException;

namespace Business.Test
{
    [TestClass]
    public class ProductManagerTest
    {
        // kurallara uymayan bir test ....
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void product_validation_check()
        {

            
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            var configFile = new FileInfo(@"log4net.config");

            // Configure Log4Net
            XmlConfigurator.Configure(logRepository, configFile);

            Mock<IProductDal> mock = new Mock<IProductDal>();
            //Mock<IProductDal> mock = new Mock<IProductDal>();

            ProductManager productManager = new ProductManager(mock.Object);

            productManager.Add(new Product());
        }
    }
}
