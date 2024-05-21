namespace Assignment_3._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 0, 2, 1, 1, 9, 1, 1 };
            int[] outputArray = ReplaceOnes(inputArray);

            Console.WriteLine("Output: [" + string.Join(", ", outputArray) + "]");
        }
        static int[] ReplaceOnes(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == 1 && array[i + 1] == 1)
                {

                    array[i] = 0;
                    array[i + 1] = 0;
                    break;
                }
            }
            return array;
        }
    }
}
