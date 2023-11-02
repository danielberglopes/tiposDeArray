using System
    ;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposDeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] MeuArray1 = new int[3];

            //  outras maneiras  de inicializar um Array com uma dimesoes

            MeuArray1[0] = 10;
            MeuArray1[1] = 5;
            MeuArray1[2] = 100;

            Console.WriteLine(MeuArray1[0]);
            Console.WriteLine(MeuArray1[1]);
            Console.WriteLine(MeuArray1[2]);

            // outras maneiras  de inicializar um Array com uma dimesoes

            int[] MaisUmArry2 = { 1, 2, 3, 4, 5, 6, };

           Console.Write(MaisUmArry2[0]);
          Console.Write(MaisUmArry2[5]);

            //  outras maneiras  de inicializar um Array de 2 dimensoes

            string[,] MeuArray2 = new string[2, 3];
              MeuArray2[0, 0] = "1";
                  MeuArray2[0, 1] = "2";
                 MeuArray2[0, 2] = "3";

                 MeuArray2[1, 0] = "4";
                 MeuArray2[1, 1] = "5";
                 MeuArray2[1, 2] = "6";

            Console.WriteLine(MeuArray2[1,0]);


            //  outras maneiras  de inicializar um Array de 2 dimensoes

              string[ , ] MeuArray5 = { { "1", "2", "3",}, { "11", "12", "13"} };

              Console.WriteLine(MeuArray5[0,2]);

             int tamanho1 =  MeuArray5.GetLength(0);
             int tamanho2 = MeuArray5.GetLength(1);
   Console.WriteLine("A peimeira dimensao do  MeuArray5 possui: " + tamanho1 + " elementos");
   Console.WriteLine("A peimeira dimensao do  MeuArray5 possui: " + tamanho2 + " elementos");



        }

    }
}
