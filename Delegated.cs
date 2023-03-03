using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager
{
    public delegate void SaveLaptopEventHandler(SaveLaptopEventArgs args);
    public class SaveLaptopEventArgs : EventArgs
    {
        public UCLaptop UCLaptop { get; set; }
        public SaveLaptopEventArgs(UCLaptop uCLaptop)
        {
            UCLaptop = uCLaptop;
        }
    }


    public delegate void DeleteLaptopEventHandler(DeleteLaptopEventArgs args);
    public class DeleteLaptopEventArgs : EventArgs
    {
        public UCLaptop UCLaptop { get; set; }
        public DeleteLaptopEventArgs(UCLaptop uCLaptop)
        {
            UCLaptop = uCLaptop;
        }
    }


    
    public delegate void LaptopSaveErrorEventHandler(LaptopSaveErrorEventArgs args);
    public class LaptopSaveErrorEventArgs : EventArgs
    {
        public string Msg { get; set; }
        public LaptopSaveErrorEventArgs(string msg)
        {
            Msg = msg;
        }
    }

}
