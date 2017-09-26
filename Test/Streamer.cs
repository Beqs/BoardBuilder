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
        private string _finalBuild;

        public void AddLogg()
        {
            Final = _finalBuild;
            saving.WriteLine("Added: " + Final);
        }

        public void RemoveLogg(string tmp)
        {
            saving.WriteLine("Removed: {0}", tmp);
        }
        
        public void SaveLogg()
        {
            saving.Close();
        }
        public string Final { get => _finalBuild; set => _finalBuild = value; }
    }
}
