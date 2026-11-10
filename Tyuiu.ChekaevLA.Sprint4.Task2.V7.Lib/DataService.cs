namespace Tyuiu.ChekaevLA.Sprint4.Task2.V7.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint4.ISprint4Task2V7
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }

            return sum;
        }
    }
}
