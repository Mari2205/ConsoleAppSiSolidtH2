using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSiSolidtH2

    // jeg gør denne class abstract fordi det skal kunne til gås ad class der arver
{/// <summary>
/// denne class er til at convert text to html
/// </summary>
    abstract class ConvertHTML
    {
        #region Convert body to html (metdoe)
        /* jeg har rykket denne metode til sin angen class fordi 
        * den ikke har noget og gøre i den anden class */
        /// <summary>
        /// jeg vil ændre typen fra "public" til "protected" fordi man skal ikke 
        /// kunne til gå denne metode ude fra main class
        /// </summary>
        /// <param name="plainText"></param>
        /// <returns></returns>
        protected string ConvertBodyToHTML(string plainText)
        {
            return "" + plainText + "";
        }
        #endregion
    }
}
