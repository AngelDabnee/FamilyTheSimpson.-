
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FamiliadeClasesTheSimpsonCorregido
{
    public class BartSimpson : HomeroSimpson, Estudian
    {

        public BartSimpson()
        {
        }

        public bool rebelde;

        public bool usaSkateBoard;

        public bool picardia;

        public bool definirRebelde()
        {
            // Recuerda definirlo para que salga en CW 
            return false;
        }

        public bool definirUsaSkateBoard()
        {
            //Recuerda definirlo para que salga en CW 
            return true;
        }

        public bool definirPicardia()
        {
            // Recuerda definirlo para que salga en CW 
            return true; 
        }
    }
}