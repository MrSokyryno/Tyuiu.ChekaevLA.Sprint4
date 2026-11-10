namespace Tyuiu.ChekaevLA.Sprint4.Task4.V26.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint4.ISprint4Task4V26
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int x = 0; x<5; x++)
            {
                for (int y = 0; y < 5; y++)
                { 
                    if (matrix[x,y] % 2 == 1) { matrix[x, y] = 0; }
                }
            }
            return matrix;
        }
    }
}
