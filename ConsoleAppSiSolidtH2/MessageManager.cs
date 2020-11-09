using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSiSolidtH2
{
    /// <summary>
    /// denne class er lavet for at holde søre for message blive sendt
    /// </summary>
     class MessageManager : ConvertHTML
    {
        #region Enum
        /// <summary>
        /// jeg har flytte denne variable til denne class fordi 
        /// det er her den bliver brugt
        /// </summary>
        public enum MessageCarrier { Smtp, VMessage }
        #endregion

        #region Redundant Code
        /// <summary>
        /// denne class er fuld af redundant kode 
        /// jeg ville slette denne class helt fordi den enste forskil der er er et paremeter 
        /// som ikke engang bliver brugt til noget enud
        /// </summary>
        /// <param name="type"></param>
        /// <param name="m"></param>
        /// <param name="isHTML"></param>
        public void sendMessage(MessageCarrier type, Message m, bool isHTML)
        {
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }
        #endregion

        #region SendMessage Metoder
        // jeg ville ændre navnet fra "sendMessageToAll" fordi den ikke alt tid vil sende en message til alle
        /// <summary>
        /// denne class er redundant med den anden class bord set fra "string[]" 
        /// som nok skal bruges på et senere tids punkt fx.
        /// hvis der skulle sende flere messages ad gangen 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="to"></param>
        /// <param name="m"></param>
        /// <param name="isHTML"></param>
        public void SendMessage(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }
        #endregion
    }
}
