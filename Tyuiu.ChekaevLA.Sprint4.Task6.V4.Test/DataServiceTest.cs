using Tyuiu.ChekaevLA.Sprint4.Task6.V4.Lib;

namespace Tyuiu.ChekaevLA.Sprint4.Task6.V4.test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] array = { "Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара" };
            string[] result = { "Москва", "Самара" };
            AssertExtensions.Equals(array, result);
        }
    }
}
