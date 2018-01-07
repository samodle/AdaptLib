using System;
using System.Collections.Generic;

namespace AdaptLib
{
    public class Gear
    {
        public Guid ID { get; set; } = new Guid();
        public AdaptText Name { get; set; }
        public WorkoutEquipment PrimaryEquipment { get; set; }
        public List<Gear> AlternateGear = new List<Gear>();
        public PriceCheck PC { get; set; }

        public double WeightKGs { get; set; }
        public double WeightLBs { get { return WeightKGs * Utils.LBsPerKG; } }

        public Gear()
        {
            
        }
    }
}
