using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSiSolidtH2
{
    /// <summary>
    /// denne class er til at instancer et message object
    /// </summary>
    public class Message
    {
        #region Class variabler 
        /* denne variabe skal være private for man skal ikke 
         * kunne ændre i classen variabler fra en anden class
         
         men disse variabler bliver ikke brugt noget sted
         */
        private string to, from, body, subject, cc;
        #endregion

        #region Get og Set
        public string To { get => to; set => to = value; }
        public string From { get => from; set => from = value; }
        public string Body { get => body; set => body = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Cc { get => cc; set => cc = value; }
        #endregion

        #region Construter
        /// <summary>
        /// her vil jeg ændre variablerne til at det get og set metoden 
        /// vil får fat i og ikke de private variabler naven i class hvis jeg måtte ænder i kode og ikke bare navnen
        /// </summary>
        /// <param name="to"></param>
        /// <param name="from"></param>
        /// <param name="body"></param>
        /// <param name="subject"></param>
        /// <param name="cc"></param>
        public Message(string to, string from, string body, string subject, string cc)
        {
            this.to = to;
            this.from = from;
            this.body = body;
            this.subject = subject;
            this.cc = cc;
        }
        #endregion

        /* jeg har rykket metoderne ud ad denne class 
         * fordi ellers ville "Message" class 
         * have mere end en ting dan skulle gøre */
    }
}
