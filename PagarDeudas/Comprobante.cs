using System;
using System.Collections.Generic;
using System.Text;

namespace PagarDeudas
{
    public class Comprobante
    {
        public DateTime FechaDeVencimiento { get; set; }

        public DateTime FechaDePago { get; set; }

        public decimal Subtotal { get; set; }

        //public decimal PorcentajeIntereses { get; set; }

        public decimal TotalIntereses { get; set; }

        public decimal Total { get; set; }

        

        
	

	}
    
}
