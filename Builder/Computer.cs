using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Computer
    {
        public string CPU { get; set; }
        public string GPU { get; set; } = "No GPU";
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string Monitor { get; set; }
        public string KeyBoard { get; set; }
        public string Mouse { get; set; }

        public override string ToString()
        {
            return $"CPU: {CPU}, GPU:{GPU}, RAM: {RAM}, Storage:{Storage}, Monitor:{Monitor}, Keyboard:{KeyBoard}, Mouse:{Mouse}";
        }

    }
}
