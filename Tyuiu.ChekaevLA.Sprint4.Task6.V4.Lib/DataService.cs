namespace Tyuiu.ChekaevLA.Sprint4.Task6.V4.Lib
{
    public class DataService: tyuiu.cources.programming.interfaces.Sprint4.ISprint4Task6V4
    {
        public string[] Calculate(string[] array)
        {
            string[] result = Array.FindAll(array, s => s.Length < 7);
            return result;
        }
    }
}
