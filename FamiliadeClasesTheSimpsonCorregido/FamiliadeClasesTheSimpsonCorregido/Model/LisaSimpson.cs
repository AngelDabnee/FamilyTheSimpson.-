
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FamiliadeClasesTheSimpsonCorregido
{
    public class LisaSimpson : HomeroSimpson, Estudian
    {

        public LisaSimpson()
        {
        }

        public bool deportista;

        public bool musica;

        public bool inteligente;

        public bool definirDeportista()
        {
            // Recuerda definirlo para que salga en CW 
            Console.WriteLine("No es una deportista");
            return false;
        }

        public bool definirMusica()
        {
            // Recuerda definirlo para que salga en CW 
            Console.WriteLine("Es musico");
            return true;
        }

        public bool definirInteligente()
        {
            // Recuerda definirlo para que salga en CW 
            Console.WriteLine("es super inteligente");
            return true;
        }

    }
}