using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Piano : Instrument
    {

        public int NumKeys { get; set; }
        public bool Acoustic { get; set; }
        public bool Pedals { get; set; }
        public string PianoType { get; set; }

    }
}
