using Tyuiu.ChekaevLA.Sprint4.Task4.V26.Lib;

namespace Tyuiu.ChekaevLA.Sprint4.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new DataService();
            int[,] array = {
                { 7, 3, 5, 3, 6 },
                { 4, 6, 2, 5, 7 },
                { 2, 3, 3, 3, 5 },
                { 2, 7, 7, 6, 2 },
                { 6, 6, 4, 3, 6 }
            };
            int[,] resarray = {
                { 0, 0, 0, 0, 6 },
                { 4, 6, 2, 0, 0 },
                { 2, 0, 0, 0, 0 },
                { 2, 0, 0, 6, 2 },
                { 6, 6, 4, 0, 6 }
            };
            AssertExtensions.Equals(resarray, service.Calculate(array));
        }
    }
}
