
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FamiliadeClasesTheSimpsonCorregido
{
    public class MonaSimpson:abuelos
    {

        public MonaSimpson()
        {
        }

        public string estadoCivilMona;

        public int edad;

        public bool amable;

        public string definirEstadoCivilMona()
        {
            // Recuerda definirlo para que salga en CW 
            string estadoCivilmona = "casada";
            return estadoCivilmona;
        }

        public int definirEdad()
        {
            // Recuerda definirlo para que salga en CW 
            int edadMona = 145;
            return edadMona;
        }

        public bool definirAmable()
        {
            // Recuerda definirlo para que salga en CW 
            return false;
        }

    }
}