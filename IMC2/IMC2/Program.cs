using System;

namespace IMC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre com idade (em número inteiro)");
            float idade = (float)Convert.ToDouble(Console.ReadLine());
            //Para ler idade como texto (string):   
            //Console.WriteLine("Entre com idade");
            //string idade2 = Console.ReadLine();

            Console.WriteLine("Entre com peso (use vírgula se necessário)");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com altura (use vírgula)");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nome da pessoa:  " + nome);
            Console.WriteLine("Idade da pessoa:  " + idade);
            //Console.WriteLine("Idade da pessoa:  " + idade2);
            Console.WriteLine("Peso da pessoa:  " + peso);
            Console.WriteLine($"Altura da pessoa:  {altura}");

            float result = peso / (altura * altura);
            // caso queira usar fórmula
            //float result = peso / Math.Pow(altura,2)

            if (result < 18.5)
            {
                Console.WriteLine("Abaixo do Peso");
            }
            else if (result >= 18.5 && result < 25)
            {
                Console.WriteLine("Peso Normal");
            }
            else if (result >= 25 && result < 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (result >= 30 && result < 40)
            {
                Console.WriteLine("Obesidade");
            }
            else
            {
                Console.WriteLine("Obesidade Grave");
            }
            Console.WriteLine("Valor do IMC da pessoa:  " + Math.Round(result, 2));
            //Console.WriteLine($"Valor do IMC da pessoa:  {Math.Round(result, 2)}"); //Utilizando $
        }
    }
}
