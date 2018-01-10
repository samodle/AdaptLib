using System;
using System.Collections.Generic;
using System.Linq;
namespace AdaptLib
{
    public class Workout
    {
        #region Variables/Properties
        public static int NumberOfWorkouts = 1;
        public int ID { get; set; } = -1;
        public AdaptText Name { get; set; } = new AdaptText();

        /*
         * 1. the order of this list is CRITICAL for the operation of the SetList set/superset functionality
         * 2. Exercizes and Equip/Gear lists need to be populated at the same time
         */
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();

        public WorkoutStructure Sets { get; set; }

        /*
         *should be populated when the exercize list is populated as this is set from that list
         */
        public List<Gear> Equip { get; private set; }
        #endregion

        private void populateEquipmentList()
        {
            foreach (Exercise e in Exercises)
            {
                foreach (Gear g in e.MyGear)
                {
                    if (!Equip.Contains(g)) { Equip.Add(g); }
                }
            }
        }

        #region Constructor
        public Workout(MisIdiomas lang, string name)
        {
            ID = NumberOfWorkouts;

            Name.Add(name, lang);

            NumberOfWorkouts++;
        }
        #endregion
    }
}
