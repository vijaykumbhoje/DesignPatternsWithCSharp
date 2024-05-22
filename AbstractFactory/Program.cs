using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client windowsClient  = new Client(new WindowsGUIFactory());
            windowsClient.CreateGUI();

            Client macClient = new Client(new MacGUIFactory());
            macClient.CreateGUI();

            Console.ReadKey();
        }
    }
}
