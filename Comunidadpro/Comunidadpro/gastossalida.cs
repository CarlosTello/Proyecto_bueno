using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comunidadpro
{
    public class gastossalida
    {
        string idgasto;
        string descripcion;
        int importe;
        string tipodezonadereparto;

        public string Idgasto
        {
            get
            {
                return idgasto;
            }

            set
            {
                idgasto = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
        }

        public string Tipodezonadereparto
        {
            get
            {
                return tipodezonadereparto;
            }

            set
            {
                tipodezonadereparto = value;
            }
        }
    }
}
