using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test
{
    class Streamer
    {
        StreamWriter saving = new StreamWriter("boards.txt", append: true);
        private string _final;

        public void save()
        {
            Final = _final;
            saving.WriteLine("Added: " + Final);
        }

        public void remove(string tmp)
        {
            saving.WriteLine("Removed: {0}", tmp);
        }
        
        public void closeLogg()
        {
            saving.Close();
        }
        public string Final { get => _final; set => _final = value; }
    }
}
