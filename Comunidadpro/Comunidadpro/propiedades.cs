using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comunidadpro
{
    public class propiedades
    {
        string tipodepropiedad;
        string codigoidentificadordelapropiedad;
        int metroscuadrados;
        string nitdelpropietario;
        List<string> gastos;
        string listaporcen;

        public string Tipodepropiedad
        {
            get
            {
                return tipodepropiedad;
            }

            set
            {
                tipodepropiedad = value;
            }
        }

        public string Codigoidentificadordelapropiedad
        {
            get
            {
                return codigoidentificadordelapropiedad;
            }

            set
            {
                codigoidentificadordelapropiedad = value;
            }
        }

        public int Metroscuadrados
        {
            get
            {
                return metroscuadrados;
            }

            set
            {
                metroscuadrados = value;
            }
        }

        public string Nitdelpropietario
        {
            get
            {
                return nitdelpropietario;
            }

            set
            {
                nitdelpropietario = value;
            }
        }

        public string Listaporcen
        {
            get
            {
                return listaporcen;
            }

            set
            {
                listaporcen = value;
            }
        }
    }
}
