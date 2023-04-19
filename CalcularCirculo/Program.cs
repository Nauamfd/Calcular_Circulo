//Estudos constantes calcular círculo


namespace CalcularCirculo
{
    public class Programa 
    {
        
        static void Main(string[] args)
        {
            Circulo cr = new Circulo();
            Console.WriteLine("Digite o valor da área do círculo:\n");
            cr.calcularCirculo(Convert.ToDouble(Console.ReadLine()));

            Console.ReadKey();
       
        }
    }

}