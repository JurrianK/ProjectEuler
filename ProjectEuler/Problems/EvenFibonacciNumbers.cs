using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    public static class EvenFibonacciNumbers
    {
        public static IEnumerable<int> GenerateFibonacciSequenceUntillMaxSequenceValue(int maximumSequenceValue)
        {
            var sequence = new List<int> { 1, 2 };

            for (var iteration = 2; iteration < sequence.Count + 1; iteration++)
            {
                var valueToAddToSequence = sequence[iteration - 2] + sequence[iteration - 1];

                if (valueToAddToSequence > maximumSequenceValue)
                {
                    break;
                }
                else
                {
                    sequence.Add(valueToAddToSequence);
                }
            }

            return sequence;
        }

        public static int CalculateSumOfEvenNumbersInSequence(IEnumerable<int> sequence)
        {
            var sum = 0;

            foreach (var value in sequence)
            {
                if (value % 2 == 0)
                {
                    sum += value;
                }
            }

            return sum;
        }
    }
}