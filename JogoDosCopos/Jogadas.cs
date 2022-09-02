using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDosCopos
{
    class Jogadas
    {
        public int N { get; set; }
        public string Copo { get; set; }
        public string Posicao1 { get; set; }
        public string Posicao2 { get; set; }
        public string Posicao3 { get; set; }

        public Jogadas(int n, string copo)
        {
            N = n;
            Copo = copo;
        }
        


        public void Jogada()
        {
            if (N <= 6)
            {

                Regra();


            }
            else
            {
                N = N / 6;
                Regra();
            }
        }
        public void Regra()
        {
            switch (N)
            {
                case 1:
                    Posicao1 = "B";
                    Posicao2 = "A";
                    Posicao3 = "C";
                    break;
                case 2:
                    Posicao1 = "B";
                    Posicao2 = "C";
                    Posicao3 = "A";
                    break;
                case 3:
                    Posicao1 = "A";
                    Posicao2 = "C";
                    Posicao3 = "B";
                    break;
                case 4:
                    Posicao1 = "C";
                    Posicao2 = "A";
                    Posicao3 = "B";
                    break;
                case 5:
                    Posicao1 = "C";
                    Posicao2 = "B";
                    Posicao3 = "A";
                    break;
                case 6:
                    Posicao1 = "A";
                    Posicao2 = "B";
                    Posicao3 = "C";
                    break;

            }

        
            switch (Copo)
            {
                case "A":
                    Console.WriteLine( Posicao1 );
                    break;
                case "B":
                    Console.WriteLine(Posicao2);
                    break;
                case "C":
                    Console.WriteLine(Posicao3);
                    break;
            }
        }
    }
}
