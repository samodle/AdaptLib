using System;
using System.Collections.Generic;

namespace AdaptLib
{
    public class Gear
    {
        public Guid ID { get; private set; } = new Guid();
        public WorkoutEquipment PrimaryEquipment { get; set; }
        public List<Gear> AlternateGear = new List<Gear>();
        public PriceCheck PC { get; set; }

        public Gear()
        {
            
        }
    }
}
