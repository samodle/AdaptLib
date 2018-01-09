using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptLib
{

    // public enum WorkoutEquipment { barbell, dumbell, speedladder, mat, box, chair, footprop, soupcans }

    public static class GearInitDB
    {
        public static List<Gear> MasterGearList = new List<Gear>();

        public static List<Gear> getMasterGearList()
        {
            List<Gear> gList = new List<Gear>();
            PriceCheck pc;
            Gear g;

            g = new Gear(WorkoutEquipment.speedladder, Utils.NA);
            g.AddText_NameDescription(MisIdiomas.english, "Speed Ladder", "Ladder helps improve coordination, strength and physical dexterity");
            pc = new PriceCheck(new DateTime(2018, 1, 9, 8, 0, 0), 25.69, "https://www.amazon.com/SKLZ-Acceleration-Explosive-Coordination-Dexterity/dp/B002CLM300", MisIdiomas.english);
            gList.Add(g);

            return gList;
        }
    }
}
