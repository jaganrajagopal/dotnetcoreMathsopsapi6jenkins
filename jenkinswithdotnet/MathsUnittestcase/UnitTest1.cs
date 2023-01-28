using MathAPI.Controllers;
namespace MathsUnittestcase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_WhenCalled_ReturnsTheSum()
        {
            var controller = new MathController();

            var result = controller.Add(1, 2);

            //Assert.Equal(3, result);
            Assert.AreEqual(3, result);
        }
    }
}