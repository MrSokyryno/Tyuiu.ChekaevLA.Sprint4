using System.Diagnostics.CodeAnalysis;

namespace Tyuiu.ChekaevLA.Sprint4.Task7.V19.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint4.ISprint4Task7V19
    {
        public int Calculate(int n, int m, string value)
        {
            int sum = 0;
            foreach (char item in value)
            {
                if (Convert.ToInt16(item) % 2 == 1) { sum += 1; }
            }
            return sum;
        }
    }
}
