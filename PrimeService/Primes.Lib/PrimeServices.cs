namespace Primes.Lib
{
    /// <summary>
    /// Servicio para determinar si un número es primo.
    /// </summary>
    public class PrimeService
    {
        /// <summary>
        /// Verifica si un número es primo.
        /// </summary>
        /// <param name="candidate">El número a verificar.</param>
        /// <returns>True si el número es primo, False en caso contrario.</returns>
        public bool IsPrime(int candidate)
        {
            // Los números menores que 2 no son primos
            if (candidate < 2) return false;
            
            // Para números del 2 al 20, verificamos si son divisibles por algún número
            // desde 2 hasta la raíz cuadrada del candidato
            for (int divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                {
                    return false; // Si es divisible, no es primo
                }
            }
            
            return true; // Si no es divisible por ningún número, es primo
        }
    }
}