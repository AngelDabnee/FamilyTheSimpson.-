using System;

namespace FamiliadeClasesTheSimpsonCorregido     // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Se crea el abuelo para utilizar sus metodos
            AbrahamSipson abrahamSipson = new AbrahamSipson();
            abrahamSipson.patriota = "Si";
            abrahamSipson.escucha = "no";
            abrahamSipson.peso = 154;
            Console.WriteLine("Tiene un peso excesivo abuelo es de " + abrahamSipson.peso + "kg");
            Console.WriteLine("Este señorón " + abrahamSipson.patriota + " es patriota " + "y " + abrahamSipson.escucha + " escucha");
            //Se creará a la abuela MonaSimpson
            MonaSimpson monaSimpson= new MonaSimpson();
            monaSimpson.edad = 145;
            monaSimpson.estadoCivilMona = "casada";
            monaSimpson.amable = false;
            Console.WriteLine("La abuela tiene una edad de " + monaSimpson.edad + " es " + monaSimpson.estadoCivilMona + " no es amable");
            //Se creará el otro abuelo, ClancyBouvier.
            ClancyBouvier clancyBouvier = new ClancyBouvier();
            clancyBouvier.nacionalidad = "Americana";
            clancyBouvier.edad = 141;
            clancyBouvier.estadoCivil = "Casado";
            Console.WriteLine("él es " + clancyBouvier.nacionalidad + "tiene una edad de " + clancyBouvier.edad + " y además " + clancyBouvier.estadoCivil);
            //Se creará el último abuelo, JaquelineBouvier. 
            JaquelineBouvier jaquelineBouvier = new JaquelineBouvier();
            jaquelineBouvier.estadoCivil = "Casada";
            jaquelineBouvier.edad = 789;
            jaquelineBouvier.viva= true;
            Console.WriteLine("Ella es " + jaquelineBouvier.estadoCivil + " tiene una edad de " + jaquelineBouvier.edad + " ¿esta viva? " + jaquelineBouvier.viva);
            //Sigue el hijo de Mona y Abrham Simpson. (homero) 
            HomeroSimpson homeroSimpson = new HomeroSimpson();
            homeroSimpson.palabraCaracteristica = "Oh ho";
            homeroSimpson.consumeAlcohol = true;
            homeroSimpson.perdidaDeCabello = true;
            homeroSimpson.peso = 145;
            homeroSimpson.pensamiento = "Buena onda";
            homeroSimpson.personalidad = "igual a su padre";
            homeroSimpson.patriota = "no";
            homeroSimpson.escucha = "No, al igual que su padre";
            homeroSimpson.humor = "igual que su mama";
            Console.WriteLine("Homero Simpson, tiene un sobre peso de " + homeroSimpson.peso + " es " + homeroSimpson.pensamiento +
                " tiene una personalidad " + homeroSimpson.personalidad + 
                " además es " + homeroSimpson.patriota + " como su padre " + " tiene un humor " + homeroSimpson.humor + 
                homeroSimpson.escucha + " se caracteriza " + homeroSimpson.palabraCaracteristica + 
                " además consume alcohol y tiene perdida de cabello");
            //Sigue MargeSimpson
            MargeSimpson margeSimpson = new MargeSimpson();
            margeSimpson.trabaja = true;
            margeSimpson.signoZodiacal = "Sabe";
            margeSimpson.paciente = "si lo es ";
            margeSimpson.edad = 123;
            margeSimpson.viva = true;
            margeSimpson.estadoCivil = "Soltera";
            Console.WriteLine("MargeSimpson, tiene una edad de " + margeSimpson.edad + " además ella es paciente " + margeSimpson.paciente
                + " ¿cuál es su signo zodiacal? " + margeSimpson.signoZodiacal + " ¿esta viva? " + margeSimpson.viva);
            //Creo que existe un problema porque hay metodos que se parecen en clases "madres"

            


        }
    }
}