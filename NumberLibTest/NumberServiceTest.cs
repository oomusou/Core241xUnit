using NumberLib;
using Xunit;

namespace NumberLibTest
{
    public class NumberServiceTest
    {
        private readonly NumberService _numberService = new NumberService();
        
        [Fact]
        public void ShouldReturnTrueGivenEvenValue()
        {
            var result = _numberService.isEven(2);
            Assert.True(result, "2 should return true");
        }
        
        [Fact]
        public void ShouldReturnFalseGivenOddValue()
        {
            var result = _numberService.isEven(1);
            Assert.False(result, "1 should return false");
        }
    }
}