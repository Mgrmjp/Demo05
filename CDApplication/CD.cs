using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDApplication
{
    class CD
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return "CD data: " + "\n - artist: " + Artist + "\n - album: " + Album + "\n - price: " + Price + "\n - - songs:\n";
        }
    }
}
