using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MacCheckbox : ICheckBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac checkbox");
        }
    }
}
