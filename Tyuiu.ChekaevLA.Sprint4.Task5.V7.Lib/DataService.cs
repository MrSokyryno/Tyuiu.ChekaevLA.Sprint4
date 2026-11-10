namespace Tyuiu.ChekaevLA.Sprint4.Task5.V7.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint4.ISprint4Task5V7
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;
            for(int x = 0; x < 5; x++) 
            {
                for (int y = 0; y < 5; y++)
                { 
                    if (matrix[x, y] < 0) { sum += 1; }
                }
            }
            return sum;
        }
    }
}
