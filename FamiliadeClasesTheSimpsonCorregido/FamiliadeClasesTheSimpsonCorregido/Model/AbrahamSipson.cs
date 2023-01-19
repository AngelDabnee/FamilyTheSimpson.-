
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FamiliadeClasesTheSimpsonCorregido
{
    public class AbrahamSipson : abuelos
    {

        public AbrahamSipson()
        {
        }

        public string pensamiento;

        public string escucha;

        public string patriota;

        public string definirPensamiento()
        {
            // El abuelo abrham sipson tendrá pensamientos correctos
            string pensamiento = "Soy buena persona";
            return pensamiento;
        }

        public string definirEscucha()
        {
            // Diremos que es medio sordo Recuerda programarlo en un CW. 
            string escucha = "no";
            return escucha;
        }

        public string definirPatriota()
        {
            //Diremos que si es patriota, recuerda programarlo en CW en program
            string patriota = "no";
            return patriota;
        }

    }
}
