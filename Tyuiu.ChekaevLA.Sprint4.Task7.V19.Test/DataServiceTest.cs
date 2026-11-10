using Tyuiu.ChekaevLA.Sprint4.Task7.V19.Lib;

namespace Tyuiu.ChekaevLA.Sprint4.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            string array = "90817264";
            Assert.AreEqual(3, dataService.Calculate(2,4, array));
        }
    }
}
