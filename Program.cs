using System;
using Matemática;
using MatemáticaResta;
using MatemáticaMultiplicación;

namespace HolaMundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Console.WriteLine("Ingresa tu nombre");
              var entrada = Console.ReadLine();
              Console.WriteLine("Ingresaste: " + entrada);
              Console.WriteLine("Ingrese exit para salir");
              var salida = Console.ReadLine();
              if(salida == "exit")
              {
                  return;
              }

              Console.Read(); */

            Console.Write("Ingrese el primer número: ");
            var numerouno = Console.ReadLine();
            Console.Write("Ingrese el segundo número: ");
            var numerodos = Console.ReadLine();
            var calculadora = new Calculadora();

            var resultado = calculadora.Sumar(int.Parse(numerouno) , int.Parse(numerodos));
            Console.WriteLine("El resultado es" + resultado);
            /*resta*/
            Console.Write("Ingrese primer numero para la resta: ");
            var numerorestauno = Console.ReadLine();
            Console.Write("Ingrese segundo número para la resta: ");
            var numerorestados = Console.ReadLine();
            var calculadoraResta = new CalculadoraResta();
            var resultadoresta = calculadoraResta.Restar(int.Parse(numerorestauno), int.Parse(numerorestados));
            Console.WriteLine("El Resultado de la resta es: " + resultadoresta);

            ////////////// multiplocación.

            Console.Write("Ingrese primer número para la multiplicación: ");
            var numerounomultiplicacion = Console.ReadLine();
            Console.Write("Ingrese segundo  número para multiplicación: ");
            var numerodosmultiplicacion = Console.ReadLine();
            var caculadoraMultiplicacion = new CalculadoraMultiplicacion();
            var resultadoMultiplicacion = calculadoraMultiplicacion.Multiplicacion(int.Parse(numerounomultiplicacion), int.Parse(numerodosmultiplicacion));
            Console.WriteLine(" El resultado de la mumtiplicación es: " + resultadoMultiplicacion);

            ////////////////// divición
            
            Console.Write("Ingrese primer número para la divicion: ");
            var numerounodivicion = Console.ReadLine();
            Console.Write("Ingrese segundo numero la dición: ");
            var numerodosdivivion = Console.ReadLine();
            var resultadodivicion = calculadoraDivicion.Divicion(int.Parce(numerounodivicion), int.Parse(numerodosdivivion));
            Console.WriteLine("El resultado de la diviciion es: " + resultadodivicion);



        
        
        
        }

    }
}
