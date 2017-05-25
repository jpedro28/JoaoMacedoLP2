using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaDoAno
{
    class Program
    {
        static void Main(string[] args)
        {
            string data, dia, mes;
            int contM = 0, contD = 0;
            data = Console.ReadLine();

            dia = data.Substring(0, 2);
            mes = data.Substring(6, 5);

            contD = Convert.ToInt16(dia);

            switch (mes)
            {
                case "janeiro":
                    contM = contD;
                    break;

                case "Janeiro":
                    contM = contD;
                    break;

                case "fevereiro":
                    contM = 31 + contD;
                    break;

                case "Fevereiro":
                    contM = 31 + contD;
                    break;

                case "março":
                    contM = 59 + contD;
                    break;

                case "Março":
                    contM = 59 + contD;
                    break;

                case "abril":
                    contM = 90 + contD;
                    break;

                case "Abril":
                    contM = 90 + contD;
                    break;

                case "maio":
                    contM = 120 + contD;
                    break;

                case "Maio":
                    contM = 120 + contD;
                    break;

                case "junho":
                    contM = 151 + contD;
                    break;

                case "Junho":
                    contM = 151 + contD;
                    break;

                case "julho":
                    contM = 181 + contD;
                    break;

                case "Julho":
                    contM = 181 + contD;
                    break;

                case "agosto":
                    contM = 212 + contD;
                    break;

                case "Agosto":
                    contM = 212 + contD;
                    break;

                case "setembro":
                    contM = 242 + contD;
                    break;

                case "Setembro":
                    contM = 242 + contD;
                    break;

                case "outubro":
                    contM = 273 + contD;
                    break;

                case "Outubro":
                    contM = 273 + contD;
                    break;

                case "novembro":
                    contM = 303 + contD;
                    break;

                case "Novembro":
                    contM = 303 + contD;
                    break;


                case "dezembro":
                    contM = 334 + contD;
                    break;

                case "Dezembro":
                    contM = 334 + contD;
                    break;
            }

            Console.WriteLine("{0}º do ano  ", contM);
            Console.ReadKey();
        }
    }
}
