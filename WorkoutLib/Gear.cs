using System;
using System.Collections.Generic;

namespace AdaptLib
{
    public class Gear
    {
        public Guid ID { get; set; } = new Guid();
        public AdaptText Name { get; set; }
        public WorkoutEquipment PrimaryEquipment { get; private set; }
        public List<Gear> AlternateGear = new List<Gear>();
        public PriceCheck PC { get; set; }

        public double WeightKGs { get; private set; }
        public double WeightLBs { get { return WeightKGs * Utils.LBsPerKG; } }


        public Gear(WorkoutEquipment e, double kgs)
        {
            WeightKGs = kgs;
            PrimaryEquipment = e;
        }
    }
}
