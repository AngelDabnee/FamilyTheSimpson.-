
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FamiliadeClasesTheSimpsonCorregido
{
    public abstract class abuelos
    {

        public abuelos()
        {
        }

        public string humor;

        public string personalidad;

        public double peso;

        public string definirHumor(string humor)
        {
            // TODO implement here
            humor = "buena onda";
            return humor;
        }

        public double definirPeso(double peso)
        {
            // TODO implement here
            peso = 1561;
            return peso;
        }

        public string definirPersonalidad(string personalidad)
        {
            // TODO implement here
            personalidad = "Chevere";
            return personalidad;
        }

    }
}