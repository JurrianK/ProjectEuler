using System.Collections.Generic;
using System.Linq;

using ProjectEuler.Problems;

using Shouldly;

using Xunit;

namespace ProjectEuler.Tests
{
    public class EvenFibonacciNumbersTests
    {
        [Fact]
        public void GenerateFibonacciSequenceUntillMaxSequenceValue_ForFirstTenIterations_ReturnsExpectedSequence()
        {
            // Arrange
            var sequence = new List<int> { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };

            // Act
            var result = EvenFibonacciNumbers.GenerateFibonacciSequenceUntillMaxSequenceValue(89).ToList();

            // Assert
            for (var index = 0; index < sequence.Count; index++)
            {
                result[index].ShouldBe(sequence[index]);
            }
        }

        [Fact]
        public void CalculateSumOfEvenNumbersInSequence_ForFibonnaciSequenceOfTenIterations_ReturnsExpectedValue()
        {
            // Arrange
            const int ExpectedSumOfFirstTenIterations = 44;

            var sequence = EvenFibonacciNumbers.GenerateFibonacciSequenceUntillMaxSequenceValue(89);

            // Act
            var result = EvenFibonacciNumbers.CalculateSumOfEvenNumbersInSequence(sequence);

            // Assert
            result.ShouldBe(ExpectedSumOfFirstTenIterations);
        }
    }
}