using System;
using System.Collections.Generic;

namespace AdaptLib
{
    public class Gear
    {

        //TD: for some things like box jumps height is the important metric

        #region Variables/Properties
        public static int NumberOfGear = 1;
        // public Guid ID { get; set; } = new Guid();
        public int ID { get; private set; } = -1;
        public AdaptText Name { get; set; } = new AdaptText();
        public AdaptText Description { get; set; } = new AdaptText();
        public WorkoutEquipment PrimaryEquipment { get; private set; }
        public List<Gear> AlternateGear = new List<Gear>();
        public PriceCheck PC { get; set; }

        public double WeightKGs { get; private set; }
        public double WeightLBs { get { return WeightKGs * Utils.LBsPerKG; } }

        public double Height { get; set; } = Utils.NA;

        public bool DoIHaveWeight { get { return (WeightKGs != Utils.NA); } }
        #endregion

        #region Constructor
        //assumes name/descript/etc will be added l8er
        public Gear(WorkoutEquipment e, double kgs)
        {
            ID = NumberOfGear;

            WeightKGs = kgs;
            PrimaryEquipment = e;

            NumberOfGear++; //MUST be in each constructor for the ID system to function properly
        }
        #endregion

        public void AddText_NameDescription(MisIdiomas i, string n, string d)
        {
            Name.Add(n, i);
            Description.Add(d, i);
        }
    }
}
