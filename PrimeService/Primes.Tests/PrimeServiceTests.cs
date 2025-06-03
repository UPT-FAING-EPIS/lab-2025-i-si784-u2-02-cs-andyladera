using Primes.Lib;
using Xunit;

namespace Primes.Tests
{
    /// <summary>
    /// Pruebas unitarias para la clase PrimeService.
    /// </summary>
    public class PrimeServiceTests
    {
        private readonly PrimeService _primeService;

        /// <summary>
        /// Constructor que inicializa una instancia de PrimeService para las pruebas.
        /// </summary>
        public PrimeServiceTests()
        {
            _primeService = new PrimeService();
        }

        /// <summary>
        /// Verifica que el número 1 no es primo.
        /// </summary>
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);
            Assert.False(result, "1 should not be prime");
        }

        /// <summary>
        /// Verifica que los valores menores que 2 no son primos.
        /// </summary>
        /// <param name="value">El valor a probar.</param>
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.False(result, $"{value} should not be prime");
        }

        /// <summary>
        /// Verifica que los números primos entre 2 y 20 son identificados correctamente.
        /// </summary>
        /// <param name="value">El número primo a probar.</param>
        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(17)]
        [InlineData(19)]
        public void IsPrime_PrimeNumbers_ReturnTrue(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.True(result, $"{value} should be prime");
        }

        /// <summary>
        /// Verifica que los números no primos entre 2 y 20 son identificados correctamente.
        /// </summary>
        /// <param name="value">El número no primo a probar.</param>
        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(12)]
        [InlineData(14)]
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(18)]
        [InlineData(20)]
        public void IsPrime_NonPrimeNumbers_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.False(result, $"{value} should not be prime");
        }
    }
}