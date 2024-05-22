using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MacGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButtons();
        }

        public ICheckBox CreateCheckBox()
        {
            return new MacCheckbox();
        }
    }
}
