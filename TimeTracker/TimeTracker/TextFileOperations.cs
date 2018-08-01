using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
    class TextFileOperations
    {
        /// <summary>
        /// überprüft ob für den Tag bereits ein Eintrag besteht
        /// </summary>
        public bool CheckIfEmpty() { return true; }

        /// <summary>
        /// gibt den bisherigen Zeitwert des heutigen Tages aus
        /// </summary>
        /// <returns>Zeit im Format hh:mm:ss</returns>
        public string ReadTime() { return null; }

        /// <summary>
        /// fügt der Textdatei einen neuen Eintrag hinzu
        /// </summary>
        public void InsertTime(string time) { }

        /// <summary>
        /// erstellt eine Liste mit den Zeiten der Woche
        /// </summary>
        public void WeekOverview()
        {
            //evtl einen array zurückgeben der 7 werte enthält? 
        }
    }
}
