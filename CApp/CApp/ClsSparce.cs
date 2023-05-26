using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{



    public class ClsSparce
    {    //Atributos
        const int Max = 30;  // Maxima Cantidad de elementos en el arreglo V alternativo
                             //fila,columna
        public int[,] Sparce = new int[Max, 3];// Vector donde se almacena los datos de las MatriZ A original
        int F;// Cantidad de filas de la Matriz A original
        int C;// Cantidad de columnas de la Matriz A original
        int cant; //cantidad de elementos


        //Constructor

        public ClsSparce()
        {
            F = 0;
            C = 0;
            cant = 0;
            int i = 0;
            while ( i < Max)
            {
                this.Sparce[i, 0] = 0;
                this.Sparce[i, 1] = 0;
                this.Sparce[i, 2] = 0;
                i++;
            }
        }

        public ClsSparce(ClsSparce m)
        {
            F = m.F;
            C = m.C;
            cant = 0;
            for (int i = 0; i < Max; i++)
            {
                Sparce[i, 0] = m.Sparce[i, 0];
                Sparce[i, 1] = m.Sparce[i, 1];
                Sparce[i, 2] = m.Sparce[i, 2];
            }
        }

        public void Limpiar()
        {
            cant = 0;
            for (int i = 0; i < Max; i++)
            {
                Sparce[i, 0] = 0;
                Sparce[i, 1] = 0;
                Sparce[i, 2] = 0;
            }
        }


        /*
 ///Matriz Original
        int[,] A = { { 1, 0, 0, 0, 0, 0 }, 
                     { 3, 2, 0, 0, 3, 0 },
                     { 0, 0, 0, 0, 0, 0 },
                     { 0, 0, 0, 0, 0,-4 },
                     { 1,-2, 0, 0, 0, 1 },
                     { 0, 0, 0, 0, 1, 0 }
                    };

 */

       //cargar valores a la matriz Sparce que devuelva una mS
       public ClsSparce CargarSparce(int[,] A)
        {
            ClsSparce p = new ClsSparce();
            p.F = A.GetLength(0);//filas
            p.C = A.GetLength(1);//columna
            p.cant = 1;
            p.Sparce[0, 0] = p.F;
            p.Sparce[0, 1] = p.C;
            for (int i = 0; i < p.F; i++)
            {
                for (int j = 0; j < p.C; j++)
                {
                    if (A[i,j]!=0)
                    {
                        p.Sparce[p.cant, 0] = i;
                        p.Sparce[p.cant, 1] = j;
                        p.Sparce[p.cant, 2] = A[i,j];
                        p.cant++;
                    }


                }
            }
            p.Sparce[0, 2] =p.cant - 1;
           // Console.WriteLine(p.MostrarMatrizSparce());
            return p;
        }

        //-- Mostrar Mostrar Original
        public String MostrarMatriz(int[,] A)
        {
            String S = "";
            F = A.GetLength(0);//fila
            C = A.GetLength(1);//columna
            for (int i = 0; i < F; i++)
            {
                S = S + "\n";//salto de Linea
                for (int j = 0; j <C; j++)
                {
                    S = S + "[" + A[i, j] + "]";
                }
                //S = S + "\n";//salto de Linea
            }
            return S;
        }

        //-- Mostrar Mostrar Original
        public String MostrarMatrizSparce()
        {
            String S = "";
          
            for (int i = 0; i < cant; i++)
            {
                //S = S + "\n";//salto de Linea
                for (int j = 0; j < 3; j++)
                {
                    S = S + "[" + Sparce[i, j] + "]";
                }
                S = S + "\n";//salto de Linea
            }
            return S;
        }




















    }
}
