using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Negocio
{
    public class PagoServicios : Aprobador
    {
        public override string Procesar(Usuario usuario)
        {
            if(usuario.motivo == "Pago de Servicios")
            {
                double Monto = usuario.monto * 18;
                return "Impuesto a pagar del 18%" + "cantidad de divisas : " + Monto;
            }
            else
            {
                return _siguiente.Procesar(usuario);
            }
        }
    }
}
