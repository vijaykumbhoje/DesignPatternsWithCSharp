using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputerBuilder builder = new ComputerBuilder();

            Computer gamingComputer = builder.SetRAM("32GB")
                .SetCPU("Intel i7")
                .SetGPU("nVidia A")
                .SetStorage("512GB SSD")
                .SetMonitor("Dell")
                .SetMouse("Logitech Wireless")
                .SetKeyboard("Logitech Keyboard")
                .Build();

            Console.WriteLine(gamingComputer.ToString());


            Computer officeComputer = builder.SetRAM("32GB")
              .SetCPU("Intel i5")
              .SetStorage("512GB HDD")
              .SetMonitor("Benq")
              .SetMouse("Wired")
              .SetKeyboard("Wired")
              .Build();

            Console.WriteLine(officeComputer.ToString());
            Console.ReadKey();
        }
    }
}
