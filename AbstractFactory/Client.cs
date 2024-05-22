using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Client
    {
        public readonly IGUIFactory _factory;

        public Client(IGUIFactory factory)
        {                       
            _factory = factory;
        }

        public void CreateGUI() 
        { 
          IButton button = _factory.CreateButton();
          ICheckBox checkBox = _factory.CreateCheckBox();

            button.Render();
            checkBox.Render();
        }
    }
}
