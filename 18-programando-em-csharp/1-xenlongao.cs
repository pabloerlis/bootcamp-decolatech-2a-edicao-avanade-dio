using System;
using System.Collections.Generic;
using System.Text;

namespace Dio
{
    class Xenlongao
    {
        static void Main(string[] args)
        {   
            int C = Convert.ToInt32(Console.ReadLine());
            int qtdTotalEsferas = Convert.ToInt32(Console.ReadLine());
            int minEsferas = 0;
            for (int l = qtdTotalEsferas; l >= 1; l--)
            {
                int num = l;
                int n = num;
                int a = 1;
                int potencia = 0;
                int ultimoDivisor = 2;

                for (int i = 2; n > 1; i++)
                {
                    if (n % i == 0)
                    {
                        bool primo = true;

                        //Verificando se é primo
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                primo = false;
                                break;
                            }
                        }
 
                        if (primo)
                        {
                            if (ultimoDivisor == i)
                            {
                                //soma mais um no expoente
                                potencia++;
                            }
                            else
                            { //Realiza o produto dos expoentes quando mudar o número primo.
                                a *= (potencia + 1);
                                ultimoDivisor = i;
                                potencia = 1;
                            }

                            n /= i;
                            i = 1;
                        }
                    }
                }
                a *= (potencia + 1);
                if (a % 2 == 0)
                {
                    minEsferas++;
                }
            }
            Console.WriteLine(minEsferas);
        }
    }
}