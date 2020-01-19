using ProjectEuler.Problems;

using Shouldly;

using Xunit;

namespace ProjectEuler.Tests
{
    public class MultiplesOfThreeAndFiveTests
    {
        [Fact]
        public void MultiplesOfThreeAndFive_ForGivenNumbers_ReturnsExpectedSum()
        {
            // Arrange
            const int ExpectedSum = 23;

            // Act
            var result = MultiplesOfThreeAndFive.CalculateSumOfThreeAndFiveMultiples(1, 10);

            // Assert
            result.ShouldBe(ExpectedSum);
        }
    }
}