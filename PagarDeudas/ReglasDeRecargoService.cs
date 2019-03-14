using System;
using System.Collections.Generic;
using System.Text;

namespace PagarDeudas
{
    class ReglasDeRecargoService
    {
        public decimal CalcularRegargo(Comprobante comprobante)
        {
            if (comprobante.FechaDePago <= comprobante.FechaDeVencimiento)
            {
                return 0;
            }

            
            
            var diasDeVencido = (comprobante.FechaDePago - comprobante.FechaDeVencimiento).Days;

            if (diasDeVencido <= 15)
            {
                return comprobante.Subtotal * Convert.ToDecimal(0.015);
            }

            if (diasDeVencido <= 30 )
            {
                return comprobante.Subtotal * Convert.ToDecimal(0.03);
            }

            if (diasDeVencido <= 60)
            {
                return comprobante.Subtotal * Convert.ToDecimal(0.04);
            }

            if (diasDeVencido > 60)
            {
                return comprobante.Subtotal * Convert.ToDecimal(0.05);
            }

            return 0;




        }




        
    }
}
