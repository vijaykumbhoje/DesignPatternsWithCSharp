using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IComputerBuilder
    {
        IComputerBuilder SetCPU(string cpu);
        IComputerBuilder SetGPU(string gpu);
        IComputerBuilder SetRAM(string ram);
        IComputerBuilder SetStorage(string storage);
        IComputerBuilder SetMonitor(string monitor);
        IComputerBuilder SetKeyboard(string keyboard);
        IComputerBuilder SetMouse(string mouse);

        Computer Build();
    }
}
