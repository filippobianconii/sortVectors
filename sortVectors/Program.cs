using System;

namespace sortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vett = new int [10]  {4,-14,100,65,76,89,54,57,78,90};
            for (int i = 0; i < vett.Length; i++)
                Console.Write(vett[i] + ", ");

            Ordina(vett);

            Console.WriteLine();
            for (int i = 0; i < vett.Length; i++)
                Console.Write(vett[i] + ", ");

            Console.WriteLine();
            Console.WriteLine("Il valore massimo è: " + Massimo(vett));

            Console.ReadKey();
        }

        static void Ordina(int[] v)
        {
            Array.Sort(v);
        }

        static int Massimo(int[] v)
        {
            if (v.Length == 0)
                return v[0];

            return v[v.Length - 1];
        }
    }
}
