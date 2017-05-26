using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comunidadpro
{
    public class localcomercial: propiedades
    {
        string nombrecomercio;
        string actividad;

        public string Nombrecomercio
        {
            get
            {
                return nombrecomercio;
            }

            set
            {
                nombrecomercio = value;
            }
        }

        public string Actividad
        {
            get
            {
                return actividad;
            }

            set
            {
                actividad = value;
            }
        }
    }
}
