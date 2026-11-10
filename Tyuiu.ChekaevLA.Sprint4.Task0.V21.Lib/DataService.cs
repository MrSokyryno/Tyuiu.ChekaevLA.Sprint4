namespace Tyuiu.ChekaevLA.Sprint4.Task0.V21.Lib
{
    public class DataService : tyuiu.cources.programming.interfaces.Sprint4.ISprint4Task0V21
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int sum = 0;
            foreach (var number in array)
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
