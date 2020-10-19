using System;

namespace Search
{
    public class BinarySearch
    {
        public int? Run(int[] list, int num)
        {
            int low = 0;
            int high = list.Length - 1;
            int mid;
            int numOfGuesses = 0;

            while (low <= high)
            {
                mid = (low + high) / 2;
                int guess = list[mid];
                if (guess == num)
                {
                    System.Console.WriteLine($"Guessed correctly: {guess}. Number of guesses: {numOfGuesses}");
                    return mid;
                }
                numOfGuesses++;
                if (guess > num)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            System.Console.WriteLine($"Number of guesses: {numOfGuesses}. Length of list: {list.Length}");
            return null;
        }
    }
}
