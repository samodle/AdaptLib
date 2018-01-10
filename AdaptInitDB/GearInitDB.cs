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
            g_sl.AddText_NameDescription(MisIdiomas.EN, "Speed Ladder", "Ladder helps improve coordination, strength and physical dexterity");
            pc = new PriceCheck(new DateTime(2018, 1, 9, 8, 0, 0), 25.69, "https://www.amazon.com/SKLZ-Acceleration-Explosive-Coordination-Dexterity/dp/B002CLM300", MisIdiomas.EN);
            g_sl.PC = pc;
            gList.Add(g_sl);

            Gear g_pb = new Gear(WorkoutEquipment.plyobox, Utils.NA);
            g_pb.AddText_NameDescription(MisIdiomas.EN, "Plyo Box", "Plyometric exercises are designed to increase speed, power, and explosiveness and are a great supplement to your regular strength training routine.");
            pc = new PriceCheck(new DateTime(2018, 1, 9, 8, 0, 0), 49.97, "https://www.walmart.com/ip/Gold-s-Gym-Extreme-Adjustable-Plyometric-Jump-Box/21811895", MisIdiomas.EN);
            g_pb.PC = pc;
            gList.Add(g_pb);

            Gear g_prb = new Gear(WorkoutEquipment.plyobox, Utils.NA);
            g_prb.AddText_NameDescription(MisIdiomas.EN, "Prop Box", "Used for resting feet on or bearing relatively light loads (<150 lbs) during exercise.");
            pc = new PriceCheck(new DateTime(2018, 1, 9, 8, 0, 0), 49.97, "https://www.walmart.com/ip/Gold-s-Gym-Extreme-Adjustable-Plyometric-Jump-Box/21811895", MisIdiomas.EN);
            g_prb.PC = pc;
            gList.Add(g_prb);


            Gear g_db = new Gear(WorkoutEquipment.dumbell, Utils.NA);
            g_db.AddText_NameDescription(MisIdiomas.EN, "Dumbell", "");
            pc = new PriceCheck(new DateTime(2018, 1, 9, 8, 0, 0), 49.97, "", MisIdiomas.EN);
            g_db.PC = pc;
            gList.Add(g_db);

            Gear g_bb = new Gear(WorkoutEquipment.barbell, Utils.NA);
            g_bb.AddText_NameDescription(MisIdiomas.EN, "Barbell", "");
            pc = new PriceCheck(new DateTime(2018, 1, 9, 8, 0, 0), 49.97, "", MisIdiomas.EN);
            g_bb.PC = pc;
            gList.Add(g_bb);

            Gear g_mt = new Gear(WorkoutEquipment.mat, Utils.NA);
            g_mt.AddText_NameDescription(MisIdiomas.EN, "Mat", "");
            pc = new PriceCheck(new DateTime(2018, 1, 9, 8, 0, 0), 49.97, "", MisIdiomas.EN);
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

            Exercise a0 = new Exercise(MisIdiomas.EN, "Star Crunch", "Start on your back with arms and legs splayed straight out and 6in off the ground like a starfish. While lifting your knees to your chest, pull your arms as far down past your butt as you can, then return to the starting position.", MuscleT1.core);

            Exercise a1 = new Exercise(MisIdiomas.EN, "Elbow Plank", "Hold your body straight, parallel to the ground resting on your feet and elbows.", MuscleT1.core);
            a1.Aliases.Add(new AdaptText("low plank", MisIdiomas.EN));

            Exercise a2 = new Exercise(MisIdiomas.EN, "Raised Feet Elbow Plank", "Hold your body straight, parallel to the ground resting on your feet on a chair or raised surface and your elbows on the ground.", MuscleT1.core);

            Exercise a3 = new Exercise(MisIdiomas.EN, "Weighted Windshield Wiper", "Start on your back with your legs at a 90 degree angle", MuscleT1.core);

            Exercise a4 = new Exercise(MisIdiomas.EN, "Hip-Up + Reach Crunch","Start lying on your back with legs straight up. Alternate between hip up and reach crunch.", MuscleT1.core); //up with legs then arms

            Exercise a5 = new Exercise(MisIdiomas.EN, "Hip-Ups","While lying on your back push your legs as high as you can, lifting your hips off the ground", MuscleT1.core);

            Exercise a6 = new Exercise(MisIdiomas.EN, "Double Crunch w/ Leg Spread", "Hands on head crunch your upper half while bending knees to crunch lower half.", MuscleT1.core);

            Exercise a7 = new Exercise(MisIdiomas.EN, "Standing Straight Crunch","Stand straight with arms extended straight above head. One leg at a time, kick straight out as high as possible while reaching as low as you can with both arms.", MuscleT1.core);

            Exercise a8 = new Exercise(MisIdiomas.EN, "Standing Twist Crunch", "With your hands on your head, alternate touching opposite knee to elbow.", MuscleT1.core);

            Exercise a9 = new Exercise(MisIdiomas.EN, "Side/Oblique Crunches, Standing hands on head, as leg kicks out to side torso bends in that direction", MuscleT1.core);

            Exercise a10 = new Exercise(MisIdiomas.EN, "Standing Twists", "Knees Bent + Weight In Butt, twist torso back and forth focusing on tight quick turns.", MuscleT1.core);

            Exercise a11 = new Exercise(MisIdiomas.EN, "Standing Chop", "One Leg At A Time Knee Thrusts Up While Arm Thrusts Down", MuscleT1.core);

            Exercise a12 = new Exercise(MisIdiomas.EN, "High Plank Knee to Elbows","From high plank position one at a time bring each leg outward one at a time, trying to get your knee as close to your shoulder as possible w/o compromising the plank position.", MuscleT1.core);

            Exercise a13 = new Exercise(MisIdiomas.EN, "Lying Leg Raise + Crunch", "Start laying flat with arms and legs fully extended. Bring your straight arms and legs up to try and form a 90 degree angle from your original torso position from each.",MuscleT1.core);

            Exercise a14 = new Exercise(MisIdiomas.EN, "High Plank: Shoulder Touches","From high plank position, alternate touching your left palm to your right shoulder then right palm to left shoulder.", MuscleT1.core);

            Exercise a15 = new Exercise(MisIdiomas.EN, "Lying Leg Twist","Starting on your back with legs straight up, rotate your waste to form an arc with your feet", MuscleT1.core);

            Exercise a16 = new Exercise(MisIdiomas.EN, "Lying Knee Twist","Perform a lying leg twist with your legs bent at the knee as much as needed.", MuscleT1.core);

            Exercise a17 = new Exercise(MisIdiomas.EN, "Russian Twists", "While sitting lean torso back to achieve 90 degree angle w knees w feet resting on ground. Rotate upper body.", MuscleT1.core);

            Exercise a18 = new Exercise(MisIdiomas.EN, "Standing Side Crunches","Place hands on head, bent knees to put weight in butt.  Bend side to side trying to touch your elbow to your knee.", MuscleT1.core);

            Exercise a19 = new Exercise(MisIdiomas.EN, "Standing Reach", "While standing, reach as high as possible with one arm and thrust the knee on that side of your body into your chest at the same time.", MuscleT1.core);

            Exercise a21 = new Exercise(MisIdiomas.EN, "Twist Crunches", "sitting cruch w twist knee to elbow, alterating sides. optional legs up on chair", MuscleT1.core);

            Exercise a22 = new Exercise(MisIdiomas.EN, "Upward Hip Thrusters", "sitting cruch position hip thrusters, optional legs on chair", MuscleT1.core);

            Exercise a23 = new Exercise(MisIdiomas.EN, "Leg Raise + Split", "Lying down, perform a 0-90 leg raise. When you return to the bottom position, bring both legs out then back in.", MuscleT1.core);

            Exercise a24 = new Exercise(MisIdiomas.EN, "Inverted Toe Touches","While laying down with legs straight up, reach up for the sky! (Shoulder blades off ground)", MuscleT1.core);

            Exercise a25 = new Exercise(MisIdiomas.EN, "Full Body Iso Hold", "lying flat on back, legs head and arms held still ~6in off the ground", MuscleT1.core);

            Exercise a26 = new Exercise(MisIdiomas.EN, "Downward Hip Thrusters","From the low plank position, thrust your hips up and down essentially in a humping motion. It looks funny but you won't be laughing for long.", MuscleT1.core);

            Exercise a27 = new Exercise(MisIdiomas.EN, "Weighted Crunch", "Laying on back with knees up, hold weight on chest and lift both shoulder blades off the ground.", MuscleT1.core);

            Exercise a28 = new Exercise(MisIdiomas.EN, "Sprinter","sitting, opposite elbow to knee. Lean torso back to achieve 90 degree angle w knees w feet resting on ground.", MuscleT1.core);

            Exercise a29 = new Exercise(MisIdiomas.EN, "High Plank: Knee To Chest","From high plank position alternate bringing one knee to your chest and then rotate it in and back out", MuscleT1.core);

            Exercise a30 = new Exercise(MisIdiomas.EN, "6 Inches: Legs", "laying on back legs six inches off the ground", MuscleT1.core);

            Exercise a31 = new Exercise(MisIdiomas.EN, "0-45 Leg Raise","While on your back move your straight legs from just above the ground (0 position) to where they make a 45 degree angle with your torso", MuscleT1.core);

            Exercise a32 = new Exercise(MisIdiomas.EN, "45-90 Leg Raise", "While on your back move your straight legs from where they make a 45 degree angle with your torso to where they make a 90 degree angle with your torso", MuscleT1.core);

            Exercise a33 = new Exercise(MisIdiomas.EN, "0-90 Leg Raise", "While on your back move your straight legs from just above the ground (0 position) to where they make a 90 degree angle with your torso", MuscleT1.core);

            Exercise a34 = new Exercise(MisIdiomas.EN, "0-90 Knee Raise", "While on your back move your knees from just above the ground (0 position) to where they make a 90 degree angle with your torso. Keep legs bent as much as needed to complete the exercise.", MuscleT1.core);

            Exercise a35 = new Exercise(MisIdiomas.EN, "The Clam","Place hands to the side of your head and the souls of your feet together.  Crunch your legs upward and lift your shoulder blades off the ground.", MuscleT1.core);

            Exercise a36 = new Exercise(MisIdiomas.EN, "Scissor Kicks", "Laying flat on back simultaneuosly kick legs laterally in opposite directions working the lower abdominal muscles", MuscleT1.core);
            a36.Aliases.Add(new AdaptText("leg crossovers", MisIdiomas.EN));
            a36.Aliases.Add(new AdaptText("side to side kicks", MisIdiomas.EN));

            Exercise a20 = new Exercise(MisIdiomas.EN, "Elbow Side Plank w/ Dips", "Resting on your side on one elbow and your feet, repeatedly dip your hips down and up.", MuscleT1.core);

            Exercise a37 = new Exercise(MisIdiomas.EN, "Elbow Side Knee Plank w/ Dips", "Resting on your side on one elbow and your feet", MuscleT1.core);

            Exercise a38 = new Exercise(MisIdiomas.EN, "Elbow Side Plank", "Resting on your side on one elbow and your feet", MuscleT1.core);

            Exercise a39 = new Exercise(MisIdiomas.EN, "Elbow Side Knee Plank", "Resting on your side on one elbow and your knees", MuscleT1.core);

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
            eList.Add(a21);
            eList.Add(a22);
            eList.Add(a23);
            eList.Add(a24);
            eList.Add(a25);
            eList.Add(a26);
            eList.Add(a27);
            eList.Add(a28);
            eList.Add(a29);
            eList.Add(a30);
            eList.Add(a31);
            eList.Add(a32);
            eList.Add(a33);
            eList.Add(a34);
            eList.Add(a35);
            eList.Add(a36);
            eList.Add(a37);
            eList.Add(a38);
            eList.Add(a39);
            MasterExerciseList = eList;

            // Exercise a = new Exercise(MisIdiomas.english, "", MuscleT1.core);

            //Workouts 
            Workout Abs_3_HASFit = new Workout(MisIdiomas.EN, "6 Pack Abs In 3 Minutes");

        }
    }
}














