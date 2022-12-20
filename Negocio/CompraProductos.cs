using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Negocio
{
    public class CompraProductos : Aprobador
    {
        public override string Procesar(Usuario usuario)
        {
            double Monto = usuario.monto * 16;
            return "Impuesto a pagar del 16% " + " cant divisas : " + Monto;
        }
    }
}
