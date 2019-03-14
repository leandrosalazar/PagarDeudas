using System;

namespace PagarDeudas
{
    class Program
    {
        static void Main(string[] args)
        {
            var FechaDeVencimiento = new DateTime(2019, 4, 15);
            var ReglasDeRecargoService = new ReglasDeRecargoService();

            var Com1 = new Comprobante();
            Com1.FechaDeVencimiento = FechaDeVencimiento;
            Console.Write("Escriba su fecha de pago: ");
            Com1.FechaDePago = Convert.ToDateTime(Console.ReadLine());




            Console.Write("Escriba el importe a pagar: $");
            Com1.Subtotal = Convert.ToDecimal(Console.ReadLine());




            var recargo = ReglasDeRecargoService.CalcularRegargo(Com1);

            Console.WriteLine("A su importe se le agregara: $" + ReglasDeRecargoService.CalcularRegargo(Com1));


            
            Console.WriteLine("Su total a pagar es de: $" + (Com1.Subtotal + ReglasDeRecargoService.CalcularRegargo(Com1)));
        
            
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
