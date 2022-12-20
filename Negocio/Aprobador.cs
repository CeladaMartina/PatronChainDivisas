using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace Negocio
{
    public abstract class Aprobador
    {
        protected Aprobador _siguiente;

        public void AgregarSiguiente(Aprobador aprobador)
        {
            _siguiente = aprobador;
        }

        public abstract string Procesar(Usuario usuario);
    }
}
