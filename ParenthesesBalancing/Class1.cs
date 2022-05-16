using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace ParenthesesBalancing
{
    public class Class1
    {
       

        public void popolaMatrice() 
        {
            Microsoft.Extensions.Logging.LoggerFactory.Create(builder => { builder.ClearProviders(); });

            string[] array = new string[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = "stringa " + i;
            }


            int[,] matrice = new int[8, 4];
            int valore = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrice[i, j] = valore;
                    valore++;
                }
            }
        }
        public int ValidateIPAddress(string IP)
        {
            var result = 0;
            var splitIP = IP.Split('.');
            if (splitIP.Length != 4)
            {
                result = 0;
            }
            else
            {
                if (splitIP[0] == null || splitIP[1] == null || splitIP[2] == null || splitIP[3] == null || splitIP[0] == string.Empty || splitIP[1] == string.Empty || splitIP[2] == string.Empty || splitIP[3] == string.Empty)
                {
                    result = 0;
                }
                else
                {
                    for (var i = 0; i < splitIP.Length; i++)
                    {
                        var numbers = splitIP[i];
                        var array = numbers.ToCharArray();
                        if (array[0] == '0')
                        {
                            result = 0;
                            break;
                        }
                        else
                        {
                            for (var j = 0; j < numbers.Length; j++)
                            {
                                if (numbers[j] >= 0 && numbers[j] <= 9)
                                {
                                    result = 0;
                                    break;
                                }
                            }

                            var number = int.Parse(numbers);
                            if (!(number <= 255))
                            {
                                result = 0;
                                break;
                            }
                            else
                            {
                                result = 1;
                                break;
                            }
                        }
                    }
                }
            }

            return result;
        }

    }
}
