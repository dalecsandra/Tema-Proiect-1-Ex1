using System;

namespace Tema_Proiect_1__Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex1
               Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
               paralelipiped dreptunghic, va afisa volumul lui*/

            int latime = 10;
            int lungime = 20;
            int inaltime = 15;

            Console.WriteLine("Acest program calculeaza volumul unui paralelipiped dreptunghic");

            Console.WriteLine("Introduceti latimea");
            latime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti lungimea");
            lungime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti inaltimea");
            inaltime = int.Parse(Console.ReadLine());

            int volumulParalelipipeduluiDreptunghic = (latime*lungime*inaltime);
            Console.WriteLine(volumulParalelipipeduluiDreptunghic);
        }
    }
}
