
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FamiliadeClasesTheSimpsonCorregido
{
    public class HugoSimpson : HomeroSimpson, Estudian
    {

        public HugoSimpson()
        {
        }

        public bool personajePrincipal;

        public bool travieso;

        public bool gemeloDeBart;

        public bool definirPersonajePrincipal()
        {
            // Recuerda definirlo para que salga en CW 
            Console.WriteLine("Este no es un personaje principal");
            return false;
        }

        public bool definirTravieso()
        {
            //Recuerda definirlo para que salga en CW 
            //Recuerda cambiarlo en program
            return true;
        }

        public bool definirGemeloDeBart()
        {
            //Recuerda definirlo para que salga en CW 
            return true;
        }

    }
}