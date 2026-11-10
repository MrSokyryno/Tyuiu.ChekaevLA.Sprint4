using Tyuiu.ChekaevLA.Sprint4.Task2.V7.Lib;

namespace Tyuiu.ChekaevLA.Sprint4.Task2.V7.Test
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
