namespace Tyuiu.ChekaevLA.Sprint4.Task3.V25.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint4.ISprint4Task3V25
    {
        public int Calculate(int[,] array)
        {
            int multy = 1;
            for (int i =0; i<5; i++)
            {
                multy *= array[i,3];
            }
            return multy;
        }
    }
}
