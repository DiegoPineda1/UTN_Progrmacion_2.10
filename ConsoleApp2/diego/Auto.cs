using ConsoleApp2.diego;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ddddd
{
    internal class Auto
    {
        public int odometro {  get; set; }
        public Tanque tanque { get; set; }
        public int kmL { get; set; }


        public Auto() 
        {
            tanque = new Tanque(20);
            odometro = 0;
            kmL = 11;
            
        }
        public Auto(int Odometro )
        {
            tanque = new Tanque(20);
            this.odometro = Odometro;
            this.kmL = 11;

        }

        public Auto(int Odometro, int puedeRecorrer)
        {
            tanque = new Tanque(20);
            this.odometro = Odometro;
            this.kmL = puedeRecorrer;

        }

        public double CargarCombustible(int lts)
        {
            return tanque.CargarTanque(lts);
        }

        public bool Conducir(int km)
        {
            bool aux = false;
            double requisitoL = km / kmL;

            if (tanque.ltsActuales >= requisitoL )
            {
                aux = true;
                odometro += km;
            }

            return aux;
        }
        public  string ToString()
        {
            return "Odometro: " + odometro + "\n"
                  + tanque.ToString() + "\n"
                  + "KML : " + kmL;
        }


    }
}

