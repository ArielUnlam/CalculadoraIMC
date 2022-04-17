using System;

namespace CalculadoraIMC.Servicios.Implementaciones
{
    public class CalculadoraIMCService : ICalculadoraIMCService
    {
        public double CalcularImc(double peso, double altura)
        {
            double imc = 0;
            imc = peso / (Math.Pow(altura, 2));
            return imc;
        }
    }

}
