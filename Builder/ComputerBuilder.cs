using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public IComputerBuilder SetCPU(string cpu)
        {
            _computer.CPU = cpu;
            return this;
        }

        public IComputerBuilder SetGPU(string gpu)
        {
            _computer.GPU = gpu;
            return this;
        }

        public IComputerBuilder SetKeyboard(string keyboard)
        {
            _computer.KeyBoard = keyboard;
            return this;
        }

        public IComputerBuilder SetMonitor(string monitor)
        {
            _computer.Monitor = monitor;
            return this;
        }

        public IComputerBuilder SetMouse(string mouse)
        {
            _computer.Mouse = mouse;
            return this;
        }

        public IComputerBuilder SetRAM(string ram)
        {
            _computer.RAM = ram;
            return this;
        }

        public IComputerBuilder SetStorage(string storage)
        {
            _computer.Storage = storage;
            return this;
        }

        public Computer Build()
        {
            Computer _builtComputer = _computer;
            Reset();
            return _builtComputer;
        }

        public Computer Reset()
        {
            return _computer = new Computer();
        }
    }
}
