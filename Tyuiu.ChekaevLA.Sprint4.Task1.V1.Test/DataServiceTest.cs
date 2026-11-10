using Tyuiu.ChekaevLA.Sprint4.Task1.V1.Lib;

namespace Tyuiu.ChekaevLA.Sprint4.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new DataService();
            int[] array = { 1, 2, 3 };

            Assert.AreEqual(2, service.Calculate(array));
        }
    }
}
