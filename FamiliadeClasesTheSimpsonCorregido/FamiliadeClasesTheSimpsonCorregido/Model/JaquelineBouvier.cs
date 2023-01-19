
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace FamiliadeClasesTheSimpsonCorregido 
{
    public class JaquelineBouvier
    {

        public JaquelineBouvier()
        {
        }

        public bool viva;

        public int edad;

        public string estadoCivil;

        public bool definirViva()
        {
            // Recuerda definirlo para que salga en CW 
            Console.WriteLine("Esta viva");
            return true;
        }

        public int definirEdad()
        {
            // Recuerda definirlo para que salga en CW 
            int edad = 789;
            return edad;
        }

        public string definirEstadoCivil()
        {
            // Recuerda definirlo para que salga en CW 
            string estadoCivilJaqueLine = "Casada";
            return estadoCivilJaqueLine;
        }
    }
    
}