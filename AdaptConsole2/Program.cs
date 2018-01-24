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
            Console.WriteLine("MasterExerciseList.Count = " + GearInitDB.MasterExerciseList.Count);
            Console.Write("MasterGearList.Count = " + GearInitDB.MasterGearList.Count);
            GearInitDB.setMasterLists();
            Console.WriteLine(" ---> " + GearInitDB.MasterGearList.Count);
            Console.WriteLine("MasterExerciseList.Count = " + GearInitDB.MasterExerciseList.Count);


            Console.WriteLine("EXERCISE_ALL.Count = " + PublicFun.EXERCISES_ALL.Count);


            Console.WriteLine("Press any key to continue. Do it. You won't...");
            Console.ReadKey(true);

        }
    }
}
