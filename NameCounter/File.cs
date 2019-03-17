using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameCounter
{
    class File
    {
        private string file;
        public string FileReader()
        {
            try
            {
                using (StreamReader streamR = new StreamReader("C:/Users/Mateu/Desktop/messages/inbox/wseikrakow20182019informatykaekonometria1rok_pjo7bamabg/message.html"))
                {
                    file = streamR.ReadLine();
                }
            }
            catch
            {
                Console.WriteLine("bład odczcytu pliku");
            }

            return file;
        }
    }
}
