using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Ahorro : Aprobador
    {
        public override string Procesar(Usuario usuario)
        {
           if(usuario.edad > 60 || usuario.edad < 24)
            {
                return "No se pueden comprar por edad";
            }

           if(usuario.meses < 9)
            {
                return "No se puede comprar fecha inferior a 9 meses";
            }

           if(usuario.motivo == "Ahorro")
            {
                double Monto = usuario.monto * 36;
                return "Impuesto a pagar del 36% , cantidad de divisas : " + Monto;
            }
            else
            {
                return _siguiente.Procesar(usuario);
            }

        }
    }
}
