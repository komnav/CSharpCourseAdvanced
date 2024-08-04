using DataAccess;
using Microsoft.IdentityModel.Tokens;

namespace MyWhereHouseTest.Tests
{
    public class MyWherehouseTests
    {
        private ProductRepository _repository;
        [SetUp]
        public void Setup()
        {
            _repository = new ProductRepository();
        }
        [Test]
        public void GIVEN_MyWhereHouse_WHEN_Add_method_is_invoked_THEN_correct_value_is_added()
        {
            _repository.Add("Apple", 10);
            var getProduct = _repository.GetAll();

            Assert.IsTrue(getProduct.Any(s => s.Name == "Apple"));
            Assert.AreEqual(10, getProduct.Count());
        }
        [Test]
        public void GIVEN_MyWhereHouse_WHEN_Get_method_is_inviked_THEN_correct_value_is_returned()
        {
            var getProduct = _repository.GetAll();
            Assert.IsNotNull(getProduct);

        }
        [Test]
        public void GIVEN_MyWhereHouse_WHEN_Get_method_is_inviked_THEN_correct_value_is_deleted()
        {
            _repository.Delete("Apple");
            var getProduct = _repository.GetAll();
            Assert.IsEmpty(getProduct);
        }

        [Test]
        public void GIVEN_MyWhereHouse_WHEN_Get_method_is_inviked_THEN_correct_value_is_update()
        {
            _repository.UpdateQuantity("Apple", 12);
            var getProduct = _repository.GetAll();
            Assert.IsNotEmpty(getProduct);
        }
    }
}