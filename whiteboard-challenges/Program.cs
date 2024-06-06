using System;

namespace whiteboard_challenges
{
    public class MostFrequentNumber
    {
        public static int GetMostFrequentNumber(int[] numbers)
        {
            int maxCount = 0;
            int mostFrequentNumber = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    mostFrequentNumber = numbers[i];
                }
            }
            return mostFrequentNumber;
        }
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
            int result = GetMostFrequentNumber(numbers);
            Console.WriteLine("The frequent number is : " + result);
        }
    }
}
