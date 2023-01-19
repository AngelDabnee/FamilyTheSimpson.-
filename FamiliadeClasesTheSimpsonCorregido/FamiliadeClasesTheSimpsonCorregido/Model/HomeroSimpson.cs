
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FamiliadeClasesTheSimpsonCorregido
{
    public class HomeroSimpson : AbrahamSipson, Trabaja
    {

        public HomeroSimpson()
        {
        }

        public string palabraCaracteristica;

        public bool perdidaDeCabello;

        public bool consumeAlcohol;

        public string definirCaracteristica()
        {
            // Recuerda definirlo para que salga en CW 
            string palabraCaracteriza = "Oh,Oh!";
            return palabraCaracteriza;
        }

        public bool definirPerdidaDeCabello()
        {
            // Recuerda definirlo para que salga en CW 
            Console.WriteLine("Este amigo pierde cabello");
            return true;
        }

        public bool definirConsumeAlcohol()
        {
            // Recuerda definirlo para que salga en CW 
            Console.WriteLine("El amigo consume alcohol");
            return true;
        }

    }
}