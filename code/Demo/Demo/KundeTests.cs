using FluentAssertions;
using Xunit;

namespace Demo
{
    public class KundeTests
    {
        [Fact]
        public void Adding_2_numbers_returns_correct_result()
        {
            var kunde = new Kunde();
            kunde.Add(1, 1).Should().Be(2);
        }
    }
}