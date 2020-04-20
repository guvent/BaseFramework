using System.ComponentModel.DataAnnotations;
using Business.Concrete;
using Entities.Abstract;
using Entities.Concrete;
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
            Mock<IProductDal> mock = new Mock<IProductDal>();
            //Mock<IProductDal> mock = new Mock<IProductDal>();

            ProductManager productManager = new ProductManager(mock.Object);

            productManager.Add(new Product());
        }
    }
}
