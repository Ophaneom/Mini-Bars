using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBars
{
    public class Config
    {
        public bool Simple_Bars { get; set; } = false;
        public bool Show_Monsters_HP { get; set; } = false;
        public bool Show_Full_Life { get; set; } = false;
        public bool Range_Verification { get; set; } = false;
        public int Distance { get; set; } = 100;
    }
}
