using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class StringHelper
    {
        public static string FazlaBosluklariSil(string ifade)
        {
            ifade = ifade.Trim();
            string YeniIfade = string.Empty;

            for(int i = 0; i < ifade.Length; i++)
            {
                if(ifade[i]==' '&&ifade[i+1]==' ')
                {
                    continue;
                }

                YeniIfade += ifade[i];
            }
            return YeniIfade;
        }
    }
}
