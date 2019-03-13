using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglaDeIntereses
{
    class EjercicioComprobante
    {
       

        static void Main(string[] args)
        {

            Comprobante.Comprobante comp1 = new Comprobante.Comprobante();
            comp1.TipoDeComprobante = ("Factura A");
            comp1.DatosClientes = ("Lucia");
            comp1.FechaDePago =  DateTime.Now;
            comp1.FechaEm = new DateTime(2019, 2, 5);
            comp1.FechaVen = new DateTime(2019, 2, 25);
            comp1.Importe = 2000;

            //var recargoService = new RegladeRecargoService();
            //var recargoCobrar = recargoService.




            Console.ReadKey();
        }

    }
}
