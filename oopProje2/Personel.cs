using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje2
{
    internal class Personel
    {
        private string tcNo;

        public string TCNO
        {
            get
            {
                return tcNo.Substring(0, 5)+"******";
            }

            set
            {
                bool kontol = false;

                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayiMi = char.IsNumber(value[i]);
                        
                        if (sayiMi)
                        {
                            //
                        }
                        else
                        {
                            kontol = true;
                            break;
                        }
                    }

                    if(kontol)
                    {
                        Console.WriteLine("Tc Kimlik numaranızda geçersiz karekter bulundu");
                    }
                    else
                    {
                        tcNo = value;
                    }
                }
                else
                {
                    Console.WriteLine("Girdiğiniz TC 11 karekterli değildir....");
                }
            }
        }
    }
}
