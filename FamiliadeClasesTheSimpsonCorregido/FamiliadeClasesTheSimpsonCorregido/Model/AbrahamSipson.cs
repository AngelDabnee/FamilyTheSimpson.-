
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

        public string definirPensamiento(string pensamiento)
        {
            // El abuelo abrham sipson tendrá pensamientos correctos
            pensamiento = "Soy buena persona";
            return pensamiento;
        }

        public string definirEscucha(string escucha)
        {
            // Diremos que es medio sordo Recuerda programarlo en un CW. 
            escucha = "no";
            Console.WriteLine(escucha);
            return escucha;
        }

        public string definirPatriota(string patriota)
        {
            //Diremos que si es patriota, recuerda programarlo en CW en program
            patriota = "este es muy patriota";
            Console.WriteLine("este es muy patriota");
            return patriota;
        }
        public string definirHumor(string humor) 
        {
            humor = "";
            return humor;
        }

    }
}
