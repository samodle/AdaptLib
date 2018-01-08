using System;
using System.Collections.Generic;
using System.Linq;
namespace AdaptLib
{
    public class Work
    {
        #region Variables/Properties
        public AdaptText Name { get; set; }

        /*
         * 1. the order of this list is CRITICAL for the operation of the SetList set/superset functionality
         * 2. Exercizes and Equip/Gear lists need to be populated at the same time
         */
        public List<Exercise> Exercises { get; private set; } = new List<Exercise>();

        //defines the set and/or superset structure of the workout. ints are indexes of the workout in the exercise list
        public List<List<int>> SetList { get; set; } = new List<List<int>>();

        /*
         *should be populated when the exercize list is populated as this is set from that list
         */
        public List<Gear> Equip { get; private set; }
        #endregion

        private void populateEquipmentList()
        {
            foreach (Exercise e in Exercises)
            {
                foreach(Gear g in e.MyGear)
                {
                    if (!Equip.Contains(g)) { Equip.Add(g); }
                }
            }
        }

        #region Constructor

        #endregion
    }
}
