namespace ProjectEuler.Problems
{
    public static class MultiplesOfThreeAndFive
    {
        public static int CalculateSumOfThreeAndFiveMultiples(int start, int iterations)
        {
            var sum = 0;

            while (start < iterations)
            {
                if (start % 3 == 0 || start % 5 == 0)
                {
                    sum += start;
                }

                start++;
            }

            return sum;
        }
    }
}