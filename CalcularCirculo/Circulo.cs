using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularCirculo
{
    //Math.PI pegar o valor PI no método Math
    public class Circulo : Programa
    {
        private double raio, perimetro, area;
        private const double PI = Math.PI;
       


        //Pega os valores do cálculo do círculo
        private static void pegarValores(double raio, double perimetro, double area) 
        {
            double RAIO = raio;
            double PERIMETRO = perimetro;
            double AREA = area;

            Console.WriteLine(" \n " + $"Raio do círculo: {RAIO}" + " \n " + $"Perimetro do círculo: {PERIMETRO}" + " \n " + $"Área do círculo: {AREA}");
        }
        
        //Calcula o perimetro e area do círculo
        //Math.Pow usado para elevar o raio ao quadrado
        public void calcularCirculo(double raio)
        {
            perimetro = 2 * PI * raio;
            area = PI * Math.Pow(raio, 2);

          
            pegarValores(raio, perimetro, area);

        }

    }



}
