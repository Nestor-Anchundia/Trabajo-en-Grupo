using System;
using Trabajo_en_clases1.NewFolder;

namespace Trabajo_en_clases1
{
    class Program
    {
        static void Main(string[] args)
        {
            Nota nota = new Nota();
            nota.Nombre = "Juan Carlos";
            Console.WriteLine(nota.Nombre);
            nota.ActividadesP1 = 2;
            nota.PracticasP1 = 10;
            nota.TrabajosautonomosP1 = 7.5f;
            nota.EVALUACIONFINALP1 = 6.5f;
            Console.WriteLine(nota.PRIMERPARCIALp1);
            Console.ReadLine();
            nota.ACTIVIDADESP2 = 6;
            nota.PRACTICASP2 = 8;
            nota.TRABAJOSAUTONOMOP2 = 9;
            nota.EVALUACIONFINALP2 = 7;
            Console.WriteLine(nota.SEGUNDOPARCIALP2);
            Console.ReadLine();
            Console.WriteLine(nota.Suma);
            Console.ReadLine();
            nota.Recuperacion = 4;
            Console.WriteLine(nota.SUMA2);
            Console.ReadLine();
            Console.WriteLine(nota.FINAL);
            Console.ReadLine();
            Console.WriteLine(nota.ESTADO);
            Console.ReadLine();
        }
    }
}
