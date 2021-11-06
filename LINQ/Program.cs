
using System.Linq;

using System.Data;

using System;

using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        public class Animal
        {
            public Species Species { get; set; }
            public String Name { get; set; }

        }

        public class Species
        {
            public String Name { get; set; }
        }



        public static void Main()
        {


            List<Species> espece = new List<Species>();
            List<Animal> animal = new List<Animal>();

            Species LionBlanc = new Species();
            Species Tortue = new Species();
            Species chat = new Species();
            Species Tigre = new Species();
            Species chien = new Species();
            Species MiniTortue = new Species();


            LionBlanc.Name = "Les cougars blanc";
 
            Tortue.Name = "Tortue albinos";

            chat.Name = "chat siamois";
 
            Tigre.Name = "Tigre blanc";

            chien.Name = "Caniche";

            MiniTortue.Name = "Tortue microspique";
     

            espece.Add(chat);
            espece.Add(chien);
            espece.Add(MiniTortue);
            espece.Add(LionBlanc);
            espece.Add(Tortue);
            espece.Add(Tigre);


            Animal Toto = new Animal();
            Animal Titi = new Animal();
            Animal Totoa = new Animal();
            Animal Titib = new Animal();
            Animal Totox = new Animal();
            Animal Titis = new Animal();



            Toto.Name = "firol";
            Titi.Name = "bunus";
            Totoa.Name = "cactus";
            Titib.Name = "abrabus";
            Totox.Name = "tutus";
            Titis.Name = "ropulus";

            Toto.Species = LionBlanc;
            Titi.Species= Tortue;
            Totoa.Species= chat;
            Titib.Species = Tigre;
            Totox.Species = chien;
            Titis.Species = MiniTortue;



            int counter = 0;
            while (counter < 3)
            {
                animal.Add(Titib);
                counter = counter+1;
            }
            counter = 0;
            while (counter < 150)
            {
                animal.Add(Titis);
                counter = counter + 1;
            }
            counter = 0;
            while (counter < 3)
            {
                animal.Add(Toto);
                counter = counter + 1;
            }
            counter = 0;
            while (counter < 100)
            {
                animal.Add(Titib);
                counter = counter + 1;
            }
            counter = 0;
            while (counter < 15)
            {
                animal.Add(Titi);
                counter = counter + 1;
            }



            IEnumerable<Animal> whiteTigers = animal.Where((a) => a.Species.Name== "Tigre blanc").ToList();
            
            Console.WriteLine($"1-Tigre Blanc .Il en Reste {whiteTigers.Count()}");

            IEnumerable<Animal> whiteCougars = animal.Where((a) => a.Species.Name == "Les cougars blanc").ToList();

            Console.WriteLine($"2-Cougars Blanc .Il en Reste {whiteCougars.Count()}");

            IEnumerable<Animal> whiteTortue = animal.Where((a) => a.Species.Name == "Tortue albinos").ToList();

            Console.WriteLine($"3-Tortue Albinos.Il en Reste {whiteTortue.Count()}");

        }
    }
}


