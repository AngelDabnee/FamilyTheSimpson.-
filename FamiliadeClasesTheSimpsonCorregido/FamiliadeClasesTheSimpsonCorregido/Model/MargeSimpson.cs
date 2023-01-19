
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FamiliadeClasesTheSimpsonCorregido 
{
    public class MargeSimpson : JaquelineBouvier, Trabaja
    {

        public MargeSimpson() 
        {
        }

        public bool trabaja;

        public string signoZodiacal;

        public string paciente;

        public bool definirTrabaja() 
        {
            // Recuerda definirlo para que salga en CW 
            Console.WriteLine("No trabaja");
            return false;
        }

        public string definirSignoZodiacal() 
        {
            // Recuerda definirlo para que salga en CW 
            string zodiaco = "no tiene nada";
            return zodiaco;
        }

        public string definirPaciente() 
        {
            // Recuerda definirlo para que salga en CW 
            string paciente = "Si lo es";
            return paciente;    
        }
        public string Trabaja() 
        {
            string trabaja1 = "no trabaja";
            return trabaja1;
        }

    }
}