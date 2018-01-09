using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptLib
{

    // public enum WorkoutEquipment { barbell, dumbell, speedladder, mat, box, chair, footprop, soupcans }

    public static class GearInitDB
    {
        public static List<Gear> MasterGearList = new List<Gear>();
        public static List<Exercise> MasterExerciseList = new List<Exercise>();

        public static void setMasterLists()
        {
            List<Gear> gList = new List<Gear>();
            PriceCheck pc;
            //Gear g;

            //First, add all gear

            Gear g_sl = new Gear(WorkoutEquipment.speedladder, Utils.NA);
            g_sl.AddText_NameDescription(MisIdiomas.english, "Speed Ladder", "Ladder helps improve coordination, strength and physical dexterity");
            pc = new PriceCheck(new DateTime(2018, 1, 9, 8, 0, 0), 25.69, "https://www.amazon.com/SKLZ-Acceleration-Explosive-Coordination-Dexterity/dp/B002CLM300", MisIdiomas.english);
            g_sl.PC = pc;
            gList.Add(g_sl);

            Gear g_pb = new Gear(WorkoutEquipment.plyobox, Utils.NA);
            g_pb.AddText_NameDescription(MisIdiomas.english, "Plyo Box", "Plyometric exercises are designed to increase speed, power, and explosiveness and are a great supplement to your regular strength training routine.");
            pc = new PriceCheck(new DateTime(2018, 1, 9, 8, 0, 0), 49.97, "https://www.walmart.com/ip/Gold-s-Gym-Extreme-Adjustable-Plyometric-Jump-Box/21811895", MisIdiomas.english);
            g_pb.PC = pc;
            gList.Add(g_pb);


            Gear g_db = new Gear(WorkoutEquipment.dumbell, Utils.NA);
            g_db.AddText_NameDescription(MisIdiomas.english, "Dumbell", "");
            pc = new PriceCheck(new DateTime(2018, 1, 9, 8, 0, 0), 49.97, "", MisIdiomas.english);
            g_db.PC = pc;
            gList.Add(g_db);

            Gear g_bb = new Gear(WorkoutEquipment.barbell, Utils.NA);
            g_bb.AddText_NameDescription(MisIdiomas.english, "Barbell", "");
            pc = new PriceCheck(new DateTime(2018, 1, 9, 8, 0, 0), 49.97, "", MisIdiomas.english);
            g_bb.PC = pc;
            gList.Add(g_bb);

            Gear g_mt = new Gear(WorkoutEquipment.mat, Utils.NA);
            g_mt.AddText_NameDescription(MisIdiomas.english, "Mat", "");
            pc = new PriceCheck(new DateTime(2018, 1, 9, 8, 0, 0), 49.97, "", MisIdiomas.english);
            g_mt.PC = pc;
            gList.Add(g_mt);

            //Next, add dependencies


            /*
            g = new Gear(WorkoutEquipment.plyobox, Utils.NA);
            g.AddText_NameDescription(MisIdiomas.english, "", "");
            pc = new PriceCheck(new DateTime(2018, 1, 9, 8, 0, 0), 49.97, "", MisIdiomas.english);
            gList.Add(g);
            */

            MasterGearList = gList;

            //EXERCISE
            List<Exercise> eList = new List<Exercise>();




            MasterExerciseList = eList;
        }
    }
}
