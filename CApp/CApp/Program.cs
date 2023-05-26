using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[,] A = { { 1, 0, 0, 0, 0, 0 },
                     { 3, 2, 0, 0, 3, 0 },
                     { 0, 0, 0, 0, 0, 0 },
                     { 0, 0, 0, 0, 0,-4 },
                     { 1,-2, 0, 0, 0, 1 },
                     { 0, 0, 0, 0, 1, 0 }
                    };


            ClsSparce m = new ClsSparce();
            
            Console.WriteLine(m.MostrarMatriz(A));
           // m.CargarSparce(A);
            Console.WriteLine("-------------------------");
            Console.WriteLine(m.CargarSparce(A).MostrarMatrizSparce());
            Console.ReadKey();
        }
    }
}
