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
        public AdaptText Description { get; set; } = new AdaptText();
        public AdaptText Instructions { get; set; } = new AdaptText();

        /*
         * 1. the order of this list is CRITICAL for the operation of the SetList set/superset functionality
         * 2. Exercizes and Equip/Gear lists need to be populated at the same time
         */
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();

        public WorkoutStructure Sets { get; set; }

        /*
         *should be populated when the exercize list is populated as this is set from that list
         */
        public List<int> Equip { get; private set; }
        #endregion

        private void populateEquipmentList()
        {
            foreach (Exercise e in Exercises)
            {
                foreach (int g in e.MyGear)
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

        public Workout(MisIdiomas lang, string name, string description): this(lang, name)
        {
            this.Description.Add(description, lang);
        }

        public Workout(MisIdiomas lang, string name, string description, string instruct): this(lang, name, description)
        {
            Instructions.Add(instruct, lang);
        }
        #endregion
    }
}
