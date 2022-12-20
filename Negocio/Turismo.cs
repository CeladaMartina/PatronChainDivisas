using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Negocio
{
    public class Turismo : Aprobador
    {
        public override string Procesar(Usuario usuario)
        {
           if(usuario.motivo == "Turismo")
            {
                double Monto = usuario.monto * 45;
                return "Impuesto a pagar del 45% , cantidad de divisas : " + Monto;
            }
            else
            {
                return _siguiente.Procesar(usuario);
            }
        }
    }
}
