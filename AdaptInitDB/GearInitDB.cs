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
            #region Variables
            WorkoutStructure x;

            //Core
            Workout Abs_3_HASFit;
            Workout Abs_5_HASFit;
            Workout Abs_5Standing_HASFit;
            Workout Abs_6_HASFit;
            Workout Abs_6Oblique_HASFit;
            Workout Abs_8A_HASFit;
            Workout Abs_8Lower_HASFit;
            Workout Abs_8B_HASFit;

            //Gym
            Workout Gym_Upper_HASFit_00;
            Workout Gym_Upper_HASFit_01;
            Workout Gym_Upper_HASFit_02;
            Workout Gym_Upper_HASFit_03;

            Workout Gym_Total_HASFit_00;
            Workout Gym_Total_HASFit_01;
            Workout Gym_Total_HASFit_02;
            Workout Gym_Total_HASFit_03;

            Workout Gym_Lower_HASFit_00;
            Workout Gym_Lower_HASFit_01;

            List<int> setL;
            List<double> timeL;
            List<int> repL;
            #endregion

            #region Gear
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
            #endregion

            #region Core Exercises
            ExerciseParams ps = new ExerciseParams(MuscleT1.core, WeightStatus.none);
            ExerciseParams ps2 = new ExerciseParams(MuscleT1.core, WeightStatus.optional);

            //EXERCISE
            List<Exercise> eList = new List<Exercise>();

            Exercise a0 = new Exercise(ps, MisIdiomas.EN, "Star Crunch", "Start on your back with arms and legs splayed straight out and 6in off the ground like a starfish. While lifting your knees to your chest, pull your arms as far down past your butt as you can, then return to the starting position.");

            Exercise a1 = new Exercise(ps, MisIdiomas.EN, "Elbow Plank", "Hold your body straight, parallel to the ground resting on your feet and elbows.");
            a1.Aliases.Add(new AdaptText("low plank", MisIdiomas.EN));

            Exercise a2 = new Exercise(ps, MisIdiomas.EN, "Raised Feet Elbow Plank", "Hold your body straight, parallel to the ground resting on your feet on a chair or raised surface and your elbows on the ground.");

            Exercise a3 = new Exercise(ps, MisIdiomas.EN, "Windshield Wiper", "Start on your back with your legs at a 90 degree angle to your torso.  Feet make a V motion coming up on alternating sides of your hands.");
            a3.WeightsNeeded = WeightStatus.preferred;

            Exercise a4 = new Exercise(ps2, MisIdiomas.EN, "Hip-Up + Reach Crunch", "Start lying on your back with legs straight up. Alternate between hip up and reach crunch."); //up with legs then arms

            Exercise a5 = new Exercise(ps, MisIdiomas.EN, "Hip-Ups", "While lying on your back push your legs as high as you can, lifting your hips off the ground");

            Exercise a6 = new Exercise(ps, MisIdiomas.EN, "Double Crunch w/ Leg Spread", "Hands on head crunch your upper half while bending knees to crunch lower half.");

            Exercise a7 = new Exercise(ps, MisIdiomas.EN, "Standing Straight Crunch", "Stand straight with arms extended straight above head. One leg at a time, kick straight out as high as possible while reaching as low as you can with both arms.");

            Exercise a8 = new Exercise(ps, MisIdiomas.EN, "Standing Twist Crunch", "With your hands on your head, alternate touching opposite knee to elbow.");

            Exercise a9 = new Exercise(ps, MisIdiomas.EN, "Side/Oblique Crunches, Standing hands on head, as leg kicks out to side torso bends in that direction");

            Exercise a10 = new Exercise(ps2, MisIdiomas.EN, "Standing Twists", "Knees Bent + Weight In Butt, twist torso back and forth focusing on tight quick turns.");

            Exercise a11 = new Exercise(ps2, MisIdiomas.EN, "Standing Chop", "One Leg At A Time Knee Thrusts Up While Arm Thrusts Down");

            Exercise a12 = new Exercise(ps, MisIdiomas.EN, "High Plank Knee to Elbows", "From high plank position one at a time bring each leg outward one at a time, trying to get your knee as close to your shoulder as possible w/o comprops, Mising the plank position.");

            Exercise a13 = new Exercise(ps2, MisIdiomas.EN, "Lying Leg Raise + Crunch", "Start laying flat with arms and legs fully extended. Bring your straight arms and legs up to try and form a 90 degree angle from your original torso position from each.");

            Exercise a14 = new Exercise(ps, MisIdiomas.EN, "High Plank: Shoulder Touches", "From high plank position, alternate touching your left palm to your right shoulder then right palm to left shoulder.");

            Exercise a15 = new Exercise(ps, MisIdiomas.EN, "Lying Leg Twist", "Starting on your back with legs straight up, rotate your waste to form an arc with your feet");

            Exercise a16 = new Exercise(ps, MisIdiomas.EN, "Lying Knee Twist", "Perform a lying leg twist with your legs bent at the knee as much as needed.");

            Exercise a17 = new Exercise(ps2, MisIdiomas.EN, "Russian Twists", "While sitting lean torso back to achieve 90 degree angle w knees w feet resting on ground. Rotate upper body.");

            Exercise a18 = new Exercise(ps, MisIdiomas.EN, "Standing Side Crunches", "Place hands on head, bent knees to put weight in butt.  Bend side to side trying to touch your elbow to your knee.");

            Exercise a19 = new Exercise(ps2, MisIdiomas.EN, "Standing Reach", "While standing, reach as high as possible with one arm and thrust the knee on that side of your body into your chest at the same time.");

            Exercise a21 = new Exercise(ps, MisIdiomas.EN, "Twist Crunch", "sitting cruch w twist knee to elbow, alterating sides. optional legs up on chair");

            Exercise a22 = new Exercise(ps, MisIdiomas.EN, "Upward Hip Thrusters", "sitting cruch position hip thrusters, optional legs on chair");

            Exercise a23 = new Exercise(ps, MisIdiomas.EN, "Leg Raise + Split", "Lying down, perform a 0-90 leg raise. When you return to the bottom position, bring both legs out then back in.");

            Exercise a24 = new Exercise(ps2, MisIdiomas.EN, "Inverted Toe Touches", "While laying down with legs straight up, reach up for the sky! (Shoulder blades off ground)");
            a24.Aliases.Add(new AdaptText("Legs Up Toe Touches", MisIdiomas.EN));

            Exercise a25 = new Exercise(ps2, MisIdiomas.EN, "Full Body Iso Hold", "lying flat on back, legs head and arms held still ~6in off the ground");

            Exercise a26 = new Exercise(ps, MisIdiomas.EN, "Downward Hip Thrusters", "From the low plank position, thrust your hips up and down essentially in a humping motion. It looks funny but you won't be laughing for long.");

            Exercise a27 = new Exercise(ps, MisIdiomas.EN, "Crunch", "Laying on back with knees up, hold weight on chest and lift both shoulder blades off the ground.");
            a27.WeightsNeeded = WeightStatus.preferred;

            Exercise a40 = new Exercise(ps, MisIdiomas.EN, "Reach Crunch", "Laying on back with knees up and feed on ground,  lift both shoulder blades off the ground reaching as straight up as possible.");
            a40.WeightsNeeded = WeightStatus.optional;

            Exercise a28 = new Exercise(ps2, MisIdiomas.EN, "Sprinter", "sitting, opposite elbow to knee. Lean torso back to achieve 90 degree angle w knees w feet resting on ground.");

            Exercise a29 = new Exercise(ps, MisIdiomas.EN, "High Plank: Knee To Chest", "From high plank position alternate bringing one knee to your chest and then rotate it in and back out");

            Exercise a30 = new Exercise(ps, MisIdiomas.EN, "6 Inches: Legs", "laying on back legs six inches off the ground");

            Exercise a31 = new Exercise(ps, MisIdiomas.EN, "0-45 Leg Raise", "While on your back move your straight legs from just above the ground (0 position) to where they make a 45 degree angle with your torso");

            Exercise a32 = new Exercise(ps, MisIdiomas.EN, "45-90 Leg Raise", "While on your back move your straight legs from where they make a 45 degree angle with your torso to where they make a 90 degree angle with your torso");

            Exercise a33 = new Exercise(ps, MisIdiomas.EN, "0-90 Leg Raise", "While on your back move your straight legs from just above the ground (0 position) to where they make a 90 degree angle with your torso");

            Exercise a34 = new Exercise(ps, MisIdiomas.EN, "0-90 Knee Raise", "While on your back move your knees from just above the ground (0 position) to where they make a 90 degree angle with your torso. Keep legs bent as much as needed to complete the exercise.");

            Exercise a35 = new Exercise(ps, MisIdiomas.EN, "The Clam", "Place hands to the side of your head and the souls of your feet together.  Crunch your legs upward and lift your shoulder blades off the ground.");

            Exercise a36 = new Exercise(ps, MisIdiomas.EN, "Scissor Kicks", "Laying flat on back simultaneuosly kick legs laterally in opposite directions working the lower abdominal muscles");
            a36.Aliases.Add(new AdaptText("leg crossovers", MisIdiomas.EN));
            a36.Aliases.Add(new AdaptText("side to side kicks", MisIdiomas.EN));

            Exercise a20 = new Exercise(ps, MisIdiomas.EN, "Elbow Side Plank w/ Dips", "Resting on your side on one elbow and your feet, repeatedly dip your hips down and up.");

            Exercise a37 = new Exercise(ps, MisIdiomas.EN, "Elbow Side Knee Plank w/ Dips", "Resting on your side on one elbow and your feet");

            Exercise a38 = new Exercise(ps, MisIdiomas.EN, "Elbow Side Plank", "Resting on your side on one elbow and your feet");

            Exercise a39 = new Exercise(ps, MisIdiomas.EN, "Elbow Side Knee Plank", "Resting on your side on one elbow and your knees");

            //nordic track, plank reach twists, situp twist down

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
            #endregion

            #region Gym Exercises
            ps = new ExerciseParams(MuscleT1.arms, WeightStatus.required);
            ps2 = new ExerciseParams(MuscleT1.arms, WeightStatus.optional);
            ExerciseParams ps3 = new ExerciseParams(MuscleT1.back, WeightStatus.required);

            //upper body
            Exercise a41 = new Exercise(ps, MisIdiomas.EN, "Incline Dumbbell Chest Press", "");
            Exercise a42 = new Exercise(ps, MisIdiomas.EN, "Incline Dumbbell Supported Row", "");
            Exercise a43 = new Exercise(ps, MisIdiomas.EN, "Dumbbell Arnold Press", "");
            Exercise a44 = new Exercise(ps, MisIdiomas.EN, "Dumbbell Upright Row", "");
            Exercise a45 = new Exercise(ps, MisIdiomas.EN, "Cable Crossovers", "");
            Exercise a46 = new Exercise(ps, MisIdiomas.EN, "Low Rope Face Pulls", "");
            Exercise a53 = new Exercise(ps, MisIdiomas.EN, "Curl", "");
            Exercise a54 = new Exercise(ps, MisIdiomas.EN, "Reverse EZ Bar Curl", "");
            Exercise a55 = new Exercise(ps, MisIdiomas.EN, "Low Rope Hammer Curl", "");
            Exercise a56 = new Exercise(ps, MisIdiomas.EN, "Bench Dips", "");
            Exercise a57 = new Exercise(ps, MisIdiomas.EN, "Incline DB Skullcrusher", "");
            Exercise a58 = new Exercise(ps, MisIdiomas.EN, "Close Grip Bench Press", "");
            Exercise a63 = new Exercise(ps, MisIdiomas.EN, "50-50 Curls", "4 x 20 (10 lower half + 10 upper half)");
            Exercise a64 = new Exercise(ps, MisIdiomas.EN, "DB California Skullcrusher", "");

            //lower body
            Exercise a47 = new Exercise(ps, MisIdiomas.EN, "Squat w/ Elevated Heels", "");
            Exercise a48 = new Exercise(ps, MisIdiomas.EN, "RDL", "");
            Exercise a49 = new Exercise(ps, MisIdiomas.EN, "One Leg Squat", "");
            Exercise a50 = new Exercise(ps, MisIdiomas.EN, "Donkey Calf Raise", "");
            Exercise a51 = new Exercise(ps, MisIdiomas.EN, "Leg Extension", "");
            Exercise a52 = new Exercise(ps, MisIdiomas.EN, "Hamstring Curls", "");
            Exercise a60 = new Exercise(ps, MisIdiomas.EN, "Conventional Deadlift", "");

            //core + total body movements
            Exercise a59 = new Exercise(ps, MisIdiomas.EN, "Ballistic Push-up + Plank Knee Tuck", "");
            Exercise a61 = new Exercise(ps, MisIdiomas.EN, "Lunge Knee Ups with Overhead Plate", "4 x 8 (each leg)");
            Exercise a62 = new Exercise(ps, MisIdiomas.EN, "Figure 8’s from bench", "4 x 10 revolutions (5 each way)");


            Exercise a65 = new Exercise(ps, MisIdiomas.EN, "7-7-7 Pull-ups", "");
            Exercise a66 = new Exercise(ps, MisIdiomas.EN, "7-7-7 Squat", "");
            Exercise a67 = new Exercise(ps, MisIdiomas.EN, "7-7-7 Dips", "");
            Exercise a68 = new Exercise(ps, MisIdiomas.EN, "7-7-7 Med Ball Sit-ups", "");

            Exercise a69 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a70 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a71 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a72 = new Exercise(ps, MisIdiomas.EN, "", "");

            Exercise a73 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a74 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a75 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a76 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a77 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a78 = new Exercise(ps, MisIdiomas.EN, "", "");

            Exercise a79 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a80 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a81 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a82 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a83 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a84 = new Exercise(ps, MisIdiomas.EN, "", "");

            Exercise a85 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a86 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a87 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a88 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a89 = new Exercise(ps, MisIdiomas.EN, "", "");
            Exercise a90 = new Exercise(ps, MisIdiomas.EN, "", "");
            //Exercise a = new Exercise(ps, MisIdiomas.EN, "", "");
            #endregion

            #region Gym Workouts
            x = new WorkoutStructure(anyTimes: false, anyDistances: false);
            repL = new List<int> { 4, 4, 6, 6, 8, 8, 10, 10 }; //{ 8, 8, 10, 10, 12, 12, 15, 15 };
            x.SetList.Add(new List<int> { 0, 1, 0, 1, 0, 1, 0, 1 });
            x.RepList.Add(repL);
            x.SetList.Add(new List<int> { 2, 3, 2, 3, 2, 3, 2, 3 });
            x.RepList.Add(repL);
            x.SetList.Add(new List<int> { 4, 5, 4, 5, 4, 5, 4, 5 });
            x.RepList.Add(repL);

            Gym_Upper_HASFit_00 = new Workout(MisIdiomas.EN, "Strength Emphasis: Muscle Building Upper Body Workout", "Drop Set Superset Chest and Back Exercises. Mix up your routine with the muscle building upper body workout. The bodybuilding drop set superset will work chest and back. Drop Set Supersets – This is a great plateau killing workout.We’ve provide both a Mass Building Emphasis version and a Strength Emphasis version of this technique.", "Start with appropriate weight for the first set and then drop 10% off the weight every set. Alternate between A1 and A2 with no rest until all sets are completed. Rest for 2 minutes before moving on to B1 and B2. Repeat for C.");
            Gym_Upper_HASFit_00.Exercises.Add(a41); //
            Gym_Upper_HASFit_00.Exercises.Add(a42); //
            Gym_Upper_HASFit_00.Exercises.Add(a43); //
            Gym_Upper_HASFit_00.Exercises.Add(a44); //
            Gym_Upper_HASFit_00.Exercises.Add(a45); //
            Gym_Upper_HASFit_00.Exercises.Add(a46); //
            Gym_Upper_HASFit_00.Sets = x;

            x = new WorkoutStructure(anyTimes: false, anyDistances: false);
            repL = new List<int> { 8, 8, 10, 10, 12, 12, 15, 15 };
            x.SetList.Add(new List<int> { 0, 1, 0, 1, 0, 1, 0, 1 });
            x.RepList.Add(repL);
            x.SetList.Add(new List<int> { 2, 3, 2, 3, 2, 3, 2, 3 });
            x.RepList.Add(repL);
            x.SetList.Add(new List<int> { 4, 5, 4, 5, 4, 5, 4, 5 });
            x.RepList.Add(repL);

            Gym_Upper_HASFit_01 = new Workout(MisIdiomas.EN, "Mass Emphasis: Muscle Building Upper Body Workout", "Drop Set Superset Chest and Back Exercises. Mix up your routine with the muscle building upper body workout. The bodybuilding drop set superset will work chest and back. Drop Set Supersets – This is a great plateau killing workout.We’ve provide both a Mass Building Emphasis version and a Strength Emphasis version of this technique.", "Start with appropriate weight for the first set and then drop 10% off the weight every set. Alternate between A1 and A2 with no rest until all sets are completed. Rest for 2 minutes before moving on to B1 and B2. Repeat for C.");
            Gym_Upper_HASFit_01.Exercises.Add(a41); //
            Gym_Upper_HASFit_01.Exercises.Add(a42); //
            Gym_Upper_HASFit_01.Exercises.Add(a43); //
            Gym_Upper_HASFit_01.Exercises.Add(a44); //
            Gym_Upper_HASFit_01.Exercises.Add(a45); //
            Gym_Upper_HASFit_01.Exercises.Add(a46); //
            Gym_Upper_HASFit_01.Sets = x;

            x = new WorkoutStructure(anyTimes: false, anyDistances: false);
            repL = new List<int> { 8, 8, 10, 10, 12, 12, 15, 15 };
            x.SetList.Add(new List<int> { 0, 1, 0, 1, 0, 1, 0, 1 });
            x.RepList.Add(repL);
            x.SetList.Add(new List<int> { 2, 3, 2, 3, 2, 3, 2, 3 });
            x.RepList.Add(repL);
            x.SetList.Add(new List<int> { 4, 5, 4, 5, 4, 5, 4, 5 });
            x.RepList.Add(repL);
            Gym_Upper_HASFit_01 = new Workout(MisIdiomas.EN, "Mass Emphasis: Muscle Building Upper Body Workout", "Drop Set Superset Chest and Back Exercises. Mix up your routine with the muscle building upper body workout. The bodybuilding drop set superset will work chest and back. Drop Set Supersets – This is a great plateau killing workout.We’ve provide both a Mass Building Emphasis version and a Strength Emphasis version of this technique.", "Start with appropriate weight for the first set and then drop 10% off the weight every set. Alternate between A1 and A2 with no rest until all sets are completed. Rest for 2 minutes before moving on to B1 and B2. Repeat for C.");
            Gym_Upper_HASFit_01.Exercises.Add(a41); //
            Gym_Upper_HASFit_01.Exercises.Add(a42); //
            Gym_Upper_HASFit_01.Exercises.Add(a43); //
            Gym_Upper_HASFit_01.Exercises.Add(a44); //
            Gym_Upper_HASFit_01.Exercises.Add(a45); //
            Gym_Upper_HASFit_01.Exercises.Add(a46); //
            Gym_Upper_HASFit_01.Sets = x;

            x = new WorkoutStructure(anyTimes: false, anyDistances: false);
            x.SetList.Add(new List<int> { 0, 1, 0, 1, 0, 1, 0, 1 });
            x.RepList.Add(new List<int> { 6, 6, 8, 8, 10, 10, 12, 12 });
            x.SetList.Add(new List<int> { 2, 3, 2, 3, 2, 3, 2, 3 });
            x.RepList.Add(new List<int> { 6, 50, 8, 40, 10, 30, 12, 20 });
            x.SetList.Add(new List<int> { 4, 5, 4, 5, 4, 5, 4, 5 });
            x.RepList.Add(new List<int> { 6, 4, 8, 6, 10, 8, 12, 10 });
            Gym_Upper_HASFit_02 = new Workout(MisIdiomas.EN, "Strength Emphasis: Muscle Building Arm Workout – Drop Set Superset Biceps and Triceps Exercises", "Experience explosive arm growth with HASfit’s muscle building biceps and triceps workout. The drop set superset technique arm workout and arm exercises is just what you need to mix up your routine. Drop Set Supersets – This is a great plateau killing workout. ", "Start with appropriate weight for the first set and then drop 10% off the weight every set. Alternate between A1, A2, A3, A1, A2, A3… with no rest until all sets are completed. Rest for 2 minutes before moving on to B1, B2, B3.");
            Gym_Upper_HASFit_02.Exercises.Add(a53); //
            Gym_Upper_HASFit_02.Exercises.Add(a54); //
            Gym_Upper_HASFit_02.Exercises.Add(a55); //
            Gym_Upper_HASFit_02.Exercises.Add(a56); //
            Gym_Upper_HASFit_02.Exercises.Add(a57); //
            Gym_Upper_HASFit_02.Exercises.Add(a58); //
            Gym_Upper_HASFit_02.Sets = x;

            x = new WorkoutStructure(anyTimes: false, anyDistances: false);
            x.SetList.Add(new List<int> { 0, 1, 0, 1, 0, 1, 0, 1 });
            x.RepList.Add(new List<int> { 8, 8, 10, 10, 12, 12, 15, 15 });
            x.SetList.Add(new List<int> { 2, 3, 2, 3, 2, 3, 2, 3 });
            x.RepList.Add(new List<int> { 8, 50, 10, 40, 12, 30, 15, 20 });
            x.SetList.Add(new List<int> { 4, 5, 4, 5, 4, 5, 4, 5 });
            x.RepList.Add(new List<int> { 8, 6, 10, 8, 12, 10, 15, 12 });
            Gym_Upper_HASFit_03 = new Workout(MisIdiomas.EN, "Mass Emphasis: Muscle Building Arm Workout – Drop Set Superset Biceps and Triceps Exercises", "Experience explosive arm growth with HASfit’s muscle building biceps and triceps workout. The drop set superset technique arm workout and arm exercises is just what you need to mix up your routine. Drop Set Supersets – This is a great plateau killing workout. ", "Start with appropriate weight for the first set and then drop 10% off the weight every set. Alternate between A1, A2, A3, A1, A2, A3… with no rest until all sets are completed. Rest for 2 minutes before moving on to B1, B2, B3.");
            Gym_Upper_HASFit_03.Exercises.Add(a53); //
            Gym_Upper_HASFit_03.Exercises.Add(a54); //
            Gym_Upper_HASFit_03.Exercises.Add(a55); //
            Gym_Upper_HASFit_03.Exercises.Add(a56); //
            Gym_Upper_HASFit_03.Exercises.Add(a57); //
            Gym_Upper_HASFit_03.Exercises.Add(a58); //
            Gym_Upper_HASFit_03.Sets = x;

            x = new WorkoutStructure(anyTimes: false, anyDistances: false);
            x.SetList.Add(new List<int> { 0, 1, 0, 1, 0, 1, 0, 1 });
            x.RepList.Add(new List<int> { 4, 4, 6, 6, 8, 8, 10, 10 });
            x.SetList.Add(new List<int> { 2, 3, 2, 3, 2, 3, 2, 3 });
            x.RepList.Add(new List<int> { 6, 50, 8, 40, 10, 30, 12, 20 });
            x.SetList.Add(new List<int> { 4, 5, 4, 5, 4, 5, 4, 5 });
            x.RepList.Add(new List<int> { 6, 6, 8, 8, 10, 10, 12, 12 });
            Gym_Lower_HASFit_00 = new Workout(MisIdiomas.EN, "Strength Emphasis: Muscle Building Lower Body Workout", "Spark new leg growth with HASfit’s muscle building lower body workout. The drop sets superset leg exercises will add variety to your routine. This legs workout is great for intermediate to advanced trainees. Drop Set Supersets – This is a great plateau killing workout.", "Start with appropriate weight for the first set and then drop 10% off the weight every set. Alternate between A1 and A2 with no rest until all sets are completed. Rest for 2 minutes before moving on to B1 and B2. Repeat for C.");
            Gym_Lower_HASFit_00.Exercises.Add(a47); //
            Gym_Lower_HASFit_00.Exercises.Add(a48); //
            Gym_Lower_HASFit_00.Exercises.Add(a49); //
            Gym_Lower_HASFit_00.Exercises.Add(a50); //
            Gym_Lower_HASFit_00.Exercises.Add(a51); //
            Gym_Lower_HASFit_00.Exercises.Add(a52); //
            Gym_Lower_HASFit_00.Sets = x;

            x = new WorkoutStructure(anyTimes: false, anyDistances: false);
            x.SetList.Add(new List<int> { 0, 1, 0, 1, 0, 1, 0, 1 });
            x.RepList.Add(new List<int> { 8, 6, 10, 8, 12, 10, 15, 12 });
            x.SetList.Add(new List<int> { 2, 3, 2, 3, 2, 3, 2, 3 });
            x.RepList.Add(new List<int> { 8, 50, 10, 40, 12, 30, 15, 20 });
            x.SetList.Add(new List<int> { 4, 5, 4, 5, 4, 5, 4, 5 });
            x.RepList.Add(new List<int> { 10, 8, 12, 10, 15, 12, 25, 15 });
            Gym_Lower_HASFit_01 = new Workout(MisIdiomas.EN, "Mass Emphasis: Muscle Building Lower Body Workout", "Spark new leg growth with HASfit’s muscle building lower body workout. The drop sets superset leg exercises will add variety to your routine. This legs workout is great for intermediate to advanced trainees. Drop Set Supersets – This is a great plateau killing workout.", "Start with appropriate weight for the first set and then drop 10% off the weight every set. Alternate between A1 and A2 with no rest until all sets are completed. Rest for 2 minutes before moving on to B1 and B2. Repeat for C.");
            Gym_Lower_HASFit_01.Exercises.Add(a47); //
            Gym_Lower_HASFit_01.Exercises.Add(a48); //
            Gym_Lower_HASFit_01.Exercises.Add(a49); //
            Gym_Lower_HASFit_01.Exercises.Add(a50); //
            Gym_Lower_HASFit_01.Exercises.Add(a51); //
            Gym_Lower_HASFit_01.Exercises.Add(a52); //
            Gym_Lower_HASFit_01.Sets = x;


            //Total Body Workouts
            x = new WorkoutStructure(anyTimes: false, anyDistances: false);
            x.SetList.Add(new List<int> { 0, 1, 0, 1, 0, 1, 0, 1 });
            x.RepList.Add(new List<int> { 5, 5, 5, 5, 5, 5, 5, 5 });
            x.SetList.Add(new List<int> { 2, 3, 2, 3, 2, 3, 2, 3 });
            x.RepList.Add(new List<int> { 8, 10, 8, 10, 8, 10, 8, 10 });
            x.SetList.Add(new List<int> { 4, 5, 4, 5, 4, 5, 4, 5 });
            x.RepList.Add(new List<int> { 20, 8, 20, 8, 20, 8, 20, 8 });
            Gym_Total_HASFit_00 = new Workout(MisIdiomas.EN, "The Vin Diesel Workout – Vin Diesel Exercises for Strength and Size Training", "The Vin Diesel workout program is a total body workout for men that consists of 3 rounds: 1. explosive power, 2. get lean & ripped, 3. arm building. The Vin Diesel exercises for strength and size training are for intermediate through advanced trainees.", "Complete this workout with the three supersets A, B, and C. Perform each exercise in a superset without breaking before moving to the next.Break for 2 minutes between supersets.Example: A1, A2, A1, A2, A1, A2, A1, A2, and then break for 2 minutes before beginning superset B.");
            Gym_Total_HASFit_00.Exercises.Add(a59); //
            Gym_Total_HASFit_00.Exercises.Add(a60); //
            Gym_Total_HASFit_00.Exercises.Add(a61); //
            Gym_Total_HASFit_00.Exercises.Add(a62); //
            Gym_Total_HASFit_00.Exercises.Add(a63); //
            Gym_Total_HASFit_00.Exercises.Add(a64); //
            Gym_Total_HASFit_00.Sets = x;

            x = new WorkoutStructure(anyTimes: false, anyDistances: false);
            repL = new List<int> { 5, 5, 5, 5 };
            x.SetList.Add(new List<int> { 0, 1, 2, 3 });
            x.RepList.Add(repL);
            x.SetList.Add(new List<int> { 0, 1, 2, 3 });
            x.RepList.Add(repL);
            x.SetList.Add(new List<int> { 0, 1, 2, 3 });
            x.RepList.Add(repL);
            x.SetList.Add(new List<int> { 0, 1, 2, 3 });
            x.RepList.Add(repL);
            x.SetList.Add(new List<int> { 0, 1, 2, 3 });
            x.RepList.Add(repL);
            Gym_Total_HASFit_01 = new Workout(MisIdiomas.EN, "21 Workout To Build Muscle – Partial Reps Exercises For Muscle Growth", "Mix up your routine with the 21 workout to build muscle. The partial reps exercises are for muscle growth and great for gaining strength.", "Perform each exercise at high intensity for the prescribed sets and repetitions.");
            Gym_Total_HASFit_01.Exercises.Add(a65); //
            Gym_Total_HASFit_01.Exercises.Add(a66); //
            Gym_Total_HASFit_01.Exercises.Add(a67); //
            Gym_Total_HASFit_01.Exercises.Add(a68); //
            Gym_Total_HASFit_01.Sets = x;
            #endregion

            #region Core Workouts
            //Workouts 
            x = new WorkoutStructure(anyTimes: true, anyDistances: false);
            setL = new List<int> { 0, 1, 2 };
            timeL = new List<double> { 1, 1, 1 };
            x.SetList.Add(setL);
            x.TimeList.Add(timeL);

            Abs_3_HASFit = new Workout(MisIdiomas.EN, "6 Pack Abs In 3 Minutes");
            Abs_3_HASFit.Exercises.Add(a13); //legs up double reach
            Abs_3_HASFit.Exercises.Add(a3);  //windshield wiper
            Abs_3_HASFit.Exercises.Add(a2);  //low plank, raised feet
            Abs_3_HASFit.Sets = x;



            x = new WorkoutStructure(anyTimes: true, anyDistances: false);
            setL = new List<int> { 0, 1, 2, 1, 3 };
            timeL = new List<double> { 0.5, 0.5, 0.5, 0.5, 0.5 };
            x.SetList.Add(setL);
            x.TimeList.Add(timeL);
            x.SetList.Add(setL);
            x.TimeList.Add(timeL);

            Abs_5_HASFit = new Workout(MisIdiomas.EN, "6 Pack Abs In 5 Minutes");
            Abs_5_HASFit.Exercises.Add(a0);  //star crunch
            Abs_5_HASFit.Exercises.Add(a1);  //low plank
            Abs_5_HASFit.Exercises.Add(a5);  //hip-ups
                                             //  Abs_5_HASFit.Exercises.Add(a1);  //low plank
            Abs_5_HASFit.Exercises.Add(a6);  //double crunch + leg spread
            Abs_5_HASFit.Sets = x;



            x = new WorkoutStructure(anyTimes: true, anyDistances: false);
            setL = new List<int> { 0, 1, 2, 3, 4, 4 };
            timeL = new List<double> { 0.5, 0.5, 0.5, 0.5, 0.25, 0.25 };
            x.SetList.Add(setL);
            x.TimeList.Add(timeL);
            x.SetList.Add(setL);
            x.TimeList.Add(timeL);

            Abs_5Standing_HASFit = new Workout(MisIdiomas.EN, "5 Minute Standing Abs Workout");
            Abs_5Standing_HASFit.Exercises.Add(a7); //alt leg standing crunch, arms extended
            Abs_5Standing_HASFit.Exercises.Add(a8); //alt elbow 2 knee hands on head
            Abs_5Standing_HASFit.Exercises.Add(a9); //oblique crunches
            Abs_5Standing_HASFit.Exercises.Add(a10); //standing twists
            Abs_5Standing_HASFit.Exercises.Add(a11); //standing chop
            Abs_5Standing_HASFit.Sets = x;




            x = new WorkoutStructure(anyTimes: true, anyDistances: false);
            setL = new List<int> { 0, 1, 2, 3, 4, 5 };
            timeL = new List<double> { 1, 1, 1, 1, 1, 1 };
            x.SetList.Add(setL);
            x.TimeList.Add(timeL);

            Abs_6_HASFit = new Workout(MisIdiomas.EN, "6 Pack Abs In 6 Minutes");
            Abs_6_HASFit.Exercises.Add(a12); //high plank knee to elbow
            Abs_6_HASFit.Exercises.Add(a13); //lying leg raise + crunch
            Abs_6_HASFit.Exercises.Add(a14); //high plank + shoulder touches
            Abs_6_HASFit.Exercises.Add(a15); //lying leg twist
            Abs_6_HASFit.Exercises.Add(a6); //double crunch + leg spread
            Abs_6_HASFit.Exercises.Add(a17); //russian twists
            Abs_6_HASFit.Sets = x;



            x = new WorkoutStructure(anyTimes: true, anyDistances: false);
            setL = new List<int> { 0, 1, 2 };
            timeL = new List<double> { 0.5, 0.5, 0.5 };
            x.SetList.Add(setL); //4x
            x.TimeList.Add(timeL);
            x.SetList.Add(setL);
            x.TimeList.Add(timeL);
            x.SetList.Add(setL);
            x.TimeList.Add(timeL);
            x.SetList.Add(setL);
            x.TimeList.Add(timeL);

            Abs_6Oblique_HASFit = new Workout(MisIdiomas.EN, "Oblique Exercises And Love Handles In 6 Minutes");
            Abs_6Oblique_HASFit.Exercises.Add(a10); //standing twist
            Abs_6Oblique_HASFit.Exercises.Add(a18); //standing side crunches
            Abs_6Oblique_HASFit.Exercises.Add(a19); //standing same arm leg reach up
            Abs_6Oblique_HASFit.Sets = x;


            x = new WorkoutStructure(anyTimes: true, anyDistances: false);
            setL = new List<int> { 0, 0, 1, 2, 3, 4, 5, 6 };
            timeL = new List<double> { 0.25, 0.25, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5 };
            x.SetList.Add(setL); //2x
            x.TimeList.Add(timeL);
            x.SetList.Add(setL);
            x.TimeList.Add(timeL);

            Abs_8A_HASFit = new Workout(MisIdiomas.EN, "8 Minutes To Ripped Abs");
            Abs_8A_HASFit.Exercises.Add(a20); //side plank + dips
            Abs_8A_HASFit.Exercises.Add(a21); //crunch w twist (1 shoulder to knee)
            Abs_8A_HASFit.Exercises.Add(a22); //upward hip thrusters
            Abs_8A_HASFit.Exercises.Add(a23); //leg raise + split
            Abs_8A_HASFit.Exercises.Add(a24); //legs up toe touches
            Abs_8A_HASFit.Exercises.Add(a25); //full body iso
            Abs_8A_HASFit.Exercises.Add(a26); //low plank hip thrusters
            Abs_8A_HASFit.Exercises.Add(a27); //weighted crunch
            Abs_8A_HASFit.Sets = x;



            x = new WorkoutStructure(anyTimes: true, anyDistances: false);
            setL = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };
            timeL = new List<double> { 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5 };
            x.SetList.Add(setL); //2x
            x.TimeList.Add(timeL);
            x.SetList.Add(setL);
            x.TimeList.Add(timeL);

            Abs_8Lower_HASFit = new Workout(MisIdiomas.EN, "Lower Ab Workout");
            Abs_8Lower_HASFit.Exercises.Add(a28); //sprinter
            Abs_8Lower_HASFit.Exercises.Add(a29); //high plank knee 2 chest
            Abs_8Lower_HASFit.Exercises.Add(a30); //6 inches
            Abs_8Lower_HASFit.Exercises.Add(a31); //0-45
            Abs_8Lower_HASFit.Exercises.Add(a32); //45-90
            Abs_8Lower_HASFit.Exercises.Add(a5); //hip-ups
            Abs_8Lower_HASFit.Exercises.Add(a36); //scissor kicks
            Abs_8Lower_HASFit.Exercises.Add(a35); //the clam
            Abs_8Lower_HASFit.Sets = x;



            x = new WorkoutStructure(anyTimes: true, anyDistances: false);
            setL = new List<int> { 0, 1, 2, 3, 4, 5, 6, 6 };
            timeL = new List<double> { 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5, 0.5 };
            x.SetList.Add(setL); //2x
            x.TimeList.Add(timeL);
            x.SetList.Add(setL);
            x.TimeList.Add(timeL);

            Abs_8B_HASFit = new Workout(MisIdiomas.EN, "Shredding 8 Min Abs");
            Abs_8B_HASFit.Exercises.Add(a35); //clam
            Abs_8B_HASFit.Exercises.Add(a15); //leg raise
            Abs_8B_HASFit.Exercises.Add(a40); //reach 4 the sky, legs down
            Abs_8B_HASFit.Exercises.Add(a31); //0-45
            Abs_8B_HASFit.Exercises.Add(a32); //45-90
            Abs_8B_HASFit.Exercises.Add(a33); //0-90
            Abs_8B_HASFit.Exercises.Add(a38); //low side plank
            Abs_8B_HASFit.Sets = x;

            #endregion

            #region Finite Plans
            WorkoutPlan Muscle_90_HASFit_00 = new WorkoutPlan(MisIdiomas.EN, "90 Days To Build Muscle");
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Gym_Upper_HASFit_00 })); //week 1
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Gym_Lower_HASFit_00 }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Gym_Upper_HASFit_02 }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Gym_Upper_HASFit_00 }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Gym_Lower_HASFit_00 }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Gym_Upper_HASFit_02 }));

            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Gym_Total_HASFit_00 })); //week 2
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Gym_Total_HASFit_01 }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day

            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { })); //week 3
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day

            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));//week 4
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day

            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));//week 5
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));

            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));//week 6
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day

            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));//week 7
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day

            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));//week 8
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));

            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Gym_Upper_HASFit_00 })); //week 9
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Gym_Lower_HASFit_00 }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Gym_Upper_HASFit_02 }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Gym_Upper_HASFit_00 }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Gym_Lower_HASFit_00 }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Gym_Upper_HASFit_02 }));

            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));//week 10
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day

            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Gym_Total_HASFit_00 }));//week 11
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day

            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));//week 12
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day

            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));//week 13
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan()); //Off Day
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));
            Muscle_90_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { }));

            #region Abs
            WorkoutPlan Abs_30_HASFit_00 = new WorkoutPlan(MisIdiomas.EN, "Six Pack Abs In 30 Days");
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_3_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_5_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_5Standing_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan());
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_6_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_5_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan());

            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_8Lower_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_8B_HASFit })); //'Shredding 8 Minute Abs'
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_5_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan());
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_8B_HASFit, Abs_3_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_6_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan());

            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_8A_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_5_HASFit, Abs_6Oblique_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_8A_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan());
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_8B_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_6Oblique_HASFit, Abs_6_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan());

            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_5Standing_HASFit, Abs_5_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_3_HASFit, Abs_8A_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_8Lower_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan());
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_6Oblique_HASFit, Abs_6_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_8B_HASFit, Abs_5_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan());

            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_8Lower_HASFit, Abs_8A_HASFit }));
            Abs_30_HASFit_00.Days.Add(new DailyPlan(new List<Workout> { Abs_8A_HASFit, Abs_8B_HASFit }));
            #endregion
            #endregion

            MasterExerciseList = eList;
        }
    }
}