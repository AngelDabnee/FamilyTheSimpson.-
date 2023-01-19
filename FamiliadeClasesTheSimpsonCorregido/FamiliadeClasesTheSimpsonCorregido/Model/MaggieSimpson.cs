
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FamiliadeClasesTheSimpsonCorregido
{
    public class MaggieSimpson : HomeroSimpson, Estudian
    {

        public MaggieSimpson()
        {
        }

        public bool ojosGrandes;

        public bool hermanaDeBart;

        public string tamaño;

        public bool definirOjosGrandes()
        {
            // Recuerda definirlo para que salga en CW 
            Console.WriteLine("tiene grandes ojos");
            return true;
        }

        public bool definirHermanaDeBart()
        {
            // Recuerda definirlo para que salga en CW 
            return true;
        }

        public string definirTamaño()
        {
            // Recuerda definirlo para que salga en CW 
            string tamaño = "pequeña";
            return tamaño;
        }

    }
}