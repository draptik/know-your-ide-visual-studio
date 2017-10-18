using FluentAssertions;
using Xunit;

namespace Demo
{
    public class FizzBuzzTests
    {
        private readonly FizzBuzz _sut;

        public FizzBuzzTests()
        {
            _sut = new FizzBuzz();
        }

        [Fact]
        public void Adding_2_numbers_returns_correct_result()
        {
            _sut.Add(1, 1).Should().Be(2);
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "Fizz")]
        public void FizzBuzz_should_return_correct_result(int input, string expectedResult)
        {
            _sut.Parse(input).Should().Be(expectedResult);
        }
    }
}