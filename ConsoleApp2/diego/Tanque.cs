using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.diego
{
    internal class Tanque
    {
        public double capacidad {  get; set; }
        public double reserva { get; set; }
        public double ltsActuales { get; set; }

        public Tanque()
        {
            capacidad = 49;
            reserva = 5;
            ltsActuales = 0;
        }

        public Tanque(double LtsActuales)
        {
            capacidad = 49;
            reserva = 5;
            this.ltsActuales = LtsActuales;
        }

        public Tanque(double Capacidad, double Reserva , double LtsActuales)
        {
            this.capacidad = Capacidad;
            this.reserva = Reserva;
            this.ltsActuales = LtsActuales;
        }

        public string Chequear()
        {
            string aux = "";
            double ltsTotal = capacidad + reserva;
            if ((ltsActuales / ltsTotal) * 100 == 100)
            {
                aux = "El tanque esta lleno";
            }
            if ((ltsActuales / ltsTotal) * 100 < 100)
            {
                aux = "El tanque tiene mas del 75%";
            }
            if ((ltsActuales / ltsTotal) * 100 == 75)
            {
                aux = "El tanque esta al 75%";
            }
            if ((ltsActuales / ltsTotal) * 100 < 75)
            {
                aux = "El tanque tiene mas del 50%";
            }
            if ((ltsActuales / ltsTotal) * 100 == 50)
            {
                aux = "El tanque esta al 50%";
            }
            if ((ltsActuales / ltsTotal) * 100 < 50)
            {
                aux = "El tanque tiene mas del 25%";
            }
            if ((ltsActuales / ltsTotal) * 100 == 25)
            {
                aux = "El tanque esta al 25%";
            }
            if ((ltsActuales / ltsTotal) * 100 < 25)
            {
                aux = "El tanque tiene menos del 25%";
            }
            if ((ltsActuales / ltsTotal) * 100 <= 5)
            {
                aux = "ESTA EN RESERVA CARGUE COMBUSTIBLE";
            }
            return aux;
        }

        public double CargarTanque(int lts)
        {
            double aux = 0;
            double carga = ltsActuales + +lts;
            double capacidadTotal =capacidad + reserva;

            if (carga > capacidadTotal)
            {
                aux = carga - capacidadTotal;

            }

            return aux;
        }

        public string ToString()
        {
            return "Capacidad : " + capacidad + "\n"
                + "Reserva: " + reserva + "\n"
                + "LtsActuales: " + ltsActuales;
        }

    }
}
