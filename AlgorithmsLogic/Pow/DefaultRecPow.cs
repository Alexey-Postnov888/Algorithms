namespace AlgorithmsLogic
{
    public class RecPow
    {
        public static void Function(int[] vector, int number)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                long result = AuxiliaryFunction(number, vector[i]);
            }
        }

        private static long AuxiliaryFunction(int number, int degree)
        {
            if(degree == 0)
            {
                return 1;
            }
            else
            {
                return number * AuxiliaryFunction(number, degree - 1);
            }
        }
    }
}