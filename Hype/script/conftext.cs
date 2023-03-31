using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hype.script
{
    class conftext
    {

        // VERIFICA EMAIL
        public static bool IsEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // VERIFICA SOMENTE NUMEROS
        public static bool IsNumero(string strNumero)
        {
            string strModelo = "^[0-9]+$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strNumero, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
