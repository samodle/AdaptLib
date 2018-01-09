using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptLib
{
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

            Gear g_prb = new Gear(WorkoutEquipment.plyobox, Utils.NA);
            g_prb.AddText_NameDescription(MisIdiomas.english, "Prop Box", "Used for resting feet on or bearing relatively light loads (<150 lbs) during exercise.");
            pc = new PriceCheck(new DateTime(2018, 1, 9, 8, 0, 0), 49.97, "https://www.walmart.com/ip/Gold-s-Gym-Extreme-Adjustable-Plyometric-Jump-Box/21811895", MisIdiomas.english);
            g_prb.PC = pc;
            gList.Add(g_prb);


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

            Exercise a0 = new Exercise(MisIdiomas.english, "Star Crunch", MuscleT1.core);

            Exercise a1 = new Exercise(MisIdiomas.english, "Elbow Plank", MuscleT1.core);

            Exercise a2 = new Exercise(MisIdiomas.english, "Raised Feet Elbow Plank", MuscleT1.core);

            Exercise a3 = new Exercise(MisIdiomas.english, "Weighted Windshield Wiper", MuscleT1.core);

            Exercise a4 = new Exercise(MisIdiomas.english, "Legs Up Alternate Hip-Up + Reach Crunch", MuscleT1.core); //up with legs then arms

            Exercise a5 = new Exercise(MisIdiomas.english, "Hip-Ups", MuscleT1.core);

            Exercise a6 = new Exercise(MisIdiomas.english, "Double Crunch w/ Leg Spread (Hands on head, bending knees)", MuscleT1.core);

            Exercise a7 = new Exercise(MisIdiomas.english, "Alternating Leg Standing Crunch, Arms Extended", MuscleT1.core);

            Exercise a8 = new Exercise(MisIdiomas.english, "Alternating Elbow To Opposite Knee, Hands On Head", MuscleT1.core);

            Exercise a9 = new Exercise(MisIdiomas.english, "Side/Oblique Crunches, Standing hands on head, as leg kicks out to side torso bends in that direction", MuscleT1.core);

            Exercise a10 = new Exercise(MisIdiomas.english, "Standing Twists, Knees Bent + Weight In Butt", MuscleT1.core);

            Exercise a11 = new Exercise(MisIdiomas.english, "Standing Chop, One Leg At A Time Knee Thrusts Up While Arm Thrusts Down", MuscleT1.core);

            Exercise a12 = new Exercise(MisIdiomas.english, "High Plank Knee to Elbows", MuscleT1.core);

            Exercise a13 = new Exercise(MisIdiomas.english, "Lying Leg Raise + Crunch", MuscleT1.core);

            Exercise a14 = new Exercise(MisIdiomas.english, "High Plank + Shoulder Touches", MuscleT1.core);

            Exercise a15 = new Exercise(MisIdiomas.english, "Lying Leg Twist", MuscleT1.core);

            Exercise a16 = new Exercise(MisIdiomas.english, "Lying Knee Twist", MuscleT1.core);

            Exercise a17 = new Exercise(MisIdiomas.english, "Russian Twists", MuscleT1.core);


            eList.Add(a0);
            eList.Add(a1);
            eList.Add(a2);
            eList.Add(a3);
            eList.Add(a4);
            eList.Add(a5);
            eList.Add(a6);
            eList.Add(a7);
            eList.Add(a8);
            eList.Add(a9);
            eList.Add(a10);
            eList.Add(a11);
            eList.Add(a12);
            eList.Add(a13);
            eList.Add(a14);
            eList.Add(a15);
            eList.Add(a16);
            eList.Add(a17);
            eList.Add(a18);
            eList.Add(a19);
            eList.Add(a20);
            MasterExerciseList = eList;

            // Exercise a = new Exercise(MisIdiomas.english, "", MuscleT1.core);
        }
    }
}














