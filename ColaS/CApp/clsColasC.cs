using System;
using System.Collections.Generic;
using System.Text;

namespace CApp
{
    public class clsColasC
    {
        //Atributos
        public const int MAX = 13;//la dimension del vector donde estaran las 3 colas
        public const int n = 4;//numero de colas
        public const int m = MAX / n;//tamaño de cada cola
        private int[] Cola;
        private int[] F;//Front va eliminando elemento de la cola
        private int[] R;//Rear va insertando datos en la cola
        private int[] B; //la cantidad de elementos cada cola
        private int[] cant = new int[n];//Cantidad se colas 

        public clsColasC()
        {
            Cola = new int[MAX];
            B = new int[n + 1];
            F = new int[n];
            R = new int[n];
            for (int i = 1; i < MAX; i++)
            {
                Cola[i] = 0;
            }
            int j = 0;
            //m=3;//n=4
            while (j < n)
            {
                cant[j] = 0;
                F[j] = (j * m) - 1;//-1,2,5,8
                R[j] = (j * m) - 1;//-1,2,5,8
                B[j] = j * m;//0,3,6,9
                j++;
            }
            B[j] = MAX;

        }

        public void Add(int c,int ele)
        {
            if (Llena(c) == false)
            {
                R[c] = (R[c] + 1) % B[c + 1];
                if (R[c] == 0)
                {
                    R[c] = B[0];
                }
                Cola[R[c]] = ele;
            }
        }

        public void Delete(int c)
        {
            if (Vacia(c))
            {
                cant[c]--;
                F[c] = (F[c] + 1) % B[c + 1];
                if (F[c] == 0)
                {
                    F[c] = B[c];

                }
                Cola[F[c]] = 0;
            }
        }

        public bool Vacia(int c)
        {
            bool S = false;
            if (cant[c] == 0)
            {
                S = true;
            }
            return S;
        }

        public int From(int c)
        {
            int x = 0;
            F[c] = (F[c] + 1) % B[c + 1];
            if (F[c] == 0)
            {
                F[c] = B[c];
            }
            x = Cola[F[c]];
            return x;
        }

        public bool Llena(int c)
        {
            bool S = false;
            if (cant[c] == m)
            {
                S = true;
            }
            return S;
        }

        public String Mostrar()
        {
            String S = "C:[";
            for (int i = 0; i < MAX; i++)
            {
                S = S + Cola[i] + "|";
            }
            S = S.Substring(0, S.Length - 1);
            S = S + "]";

            return S ;
        }

    }
}
