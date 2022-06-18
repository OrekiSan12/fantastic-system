/*************************************************************
Institución:    Facultad de Cs. de la Comutacion - UAGRM
Materia:        Estructura de Datos I
Proyecto:       cApp (Proyecto de Clases)
Descripción:    Implementacion del TAD Multiples Colas utilizando Arreglos.
Creador:        Fernando Angulo
Lenguaje:       C#
*************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace CApp
{
    public class clsColaS
    {
        //Atributos
        public const int MAX = 9;//la dimension del vector donde estaran las 3 colas
        public const int n = 3;//numero de colas
        public const int t = MAX / n;//tamaño de cada cola
        private int[] Cola;
        private int[] F;//Front va eliminando elemento de la cola
        private int[] R;//Rear va insertando datos en la cola
        private int[] B; //la cantidad de elementos cada cola
        
        //Constructor
        public clsColaS()
        {
            Cola = new int[MAX];
            B = new int[n + 1];
            F = new int[n];
            R = new int[n];
            for(int i = 1; i < MAX; i++)
            {
                Cola[i] = 0;
            }
            int j = 0;
            while (j < n)
            {
                F[j] = (j * t) - 1;//-1,2,5
                R[j] = (j * t) - 1;
                B[j] = j * t;//0,3,6
                j++;
            }
            B[j] = MAX;

        }

        public void Add(int c,int ele)
        {
            if (Llena(c) == false)
            {
                R[c]++;
                Cola[R[c]] = ele;
            }
        }
        public void Delete(int c)
        {
            if (Vacia(c) == false)
            {
                F[c]++;
            }
        }

        public int From(int c)
        {
            return Cola[F[c] + 1];
        }

        public bool Vacia(int c)
        {
            bool s = false;
            if (F[c] == R[c])
            {
                s = true;
            }
            return s;
        }

        public bool Llena(int c)
        {
            bool S = false;
            if (R[c] + 1 == B[c + 1])
            {
                S = true;
            }
            return S;
        }
       
        public String Mostrar()
        {
            String S = "C:[";
            for(int i = 0; i < n; i++)
            {
                for (int j = F[i]+1; j <= R[i]; j++)
                {
                    S = S + Cola[j] + "|";
                }
            }
            S = S + "]";
            return S;
        }

    }
}
