using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comunidadpro
{
    public class gastos
    {
        string identificacion;
        string nombre;
        string tipodereparto;

        public string Identificacion
        {
            get
            {
                return identificacion;
            }

            set
            {
                identificacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Tipodereparto
        {
            get
            {
                return tipodereparto;
            }

            set
            {
                tipodereparto = value;
            }
        }
    }
}
