using Xunit;
using PrimeServiceProject.Pages;

namespace PrimeServiceProject.Tests
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        #region Not Prime Tests
        //[Fact]
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(6)] 
        public void ReturnFalseGivenValue(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.False(result, $"{value} should not be prime");
        }
        #endregion

        #region Prime Tests
        //[Fact]
         [Theory] 
        [InlineData(2)] 
        [InlineData(3)] 
        [InlineData(5)] 
        [InlineData(7)] 
        public void ReturnTrueGivenValue(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.True(result, $"{value} should be prime");
        }
        #endregion
    }
}