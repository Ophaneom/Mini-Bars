using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBars
{
    public class Config
    {
        public int Bars_Theme { get; set; } = 2;
        public bool Only_One_Theme { get; set; } = false;
        public bool Show_Monsters_HP { get; set; } = false;
        public bool Show_Full_Life { get; set; } = true;
        public bool Range_Verification { get; set; } = false;
        public int Distance { get; set; } = 100;
    }
}
