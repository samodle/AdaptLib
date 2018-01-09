using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdaptLib;

namespace AdaptConsole2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Wassup World! err ref#80085");
            Console.WriteLine("MasterGearList.Count = " + GearInitDB.MasterGearList.Count);
            GearInitDB.setMasterLists();
            Console.WriteLine("MasterGearList.Count = " + GearInitDB.MasterGearList.Count);
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);

        }
    }
}
