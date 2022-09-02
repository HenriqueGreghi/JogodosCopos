using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDosCopos
{
    class Jogadas
    {
        public int N { get; set; }
        public string Copos{ get; set; }

        public Jogadas(int n, string copos)
        {
            N = n;
            Copos = copos;
        }

        public void Jogada()
        {
            int numero, Copo;
            int cont = 0;

            if (Copos[0] == 'A')
            {
                Copo = 1;
            }
            else
            {
                if (Copos[0] == 'B')
                {
                    Copo = 2;
                }
                else
                {
                    Copo = 3;
                }
            }
            while (cont < N)
            {
                numero = int.Parse(Console.ReadLine());
                if (numero == 1)
                {
                    if (Copo != 3)
                    {
                        if (Copo == 1)
                        {
                            Copo = 2;
                        }
                        else
                        {
                            Copo = 1;
                        }
                    }
                }
                else
                {
                    if (numero == 2)
                    {
                        if (Copo != 1)
                        {
                            if (Copo == 2)
                            {
                                Copo = 3;
                            }
                            else
                            {
                                Copo = 2;
                            }
                        }
                    }
                    else
                    {
                        if (Copo != 2)
                        {
                            if (Copo == 1)
                            {
                                Copo = 3;
                            }
                            else
                            {
                                Copo = 1;
                            }
                        }
                    }
                }
                cont++;
            }
            if (Copo == 1)
            {
                Console.WriteLine();
                Console.Write("A");
               
            }
            else
            {
                if (Copo == 2)
                {
                    Console.WriteLine();
                    Console.Write("B");
                    
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("C");
                    
                }
            }

        }

    }
}

