using System;
using System.Collections.Generic;
namespace AdaptLib
{
    public class Exercise 
    {
        public Guid ID = new Guid();
        public List<Gear> MyGear { get; set; } = new List<Gear>();

        public AdaptText Name { get; set; }
        public AdaptText Description { get; set; }
        public AdaptText Instructions { get; set; }

    
        public Tier1Muscle PrimaryMuscleGroup { get; set; }
        public Tier2Muscle SecondaryMuscleGroup { get; set; }

        /* To Do: Add image, adapttext dictionary */

        public Exercise(MisIdiomas l, string name, string description, Tier1Muscle m1)
        {
            this.Name.Add(name, l);
            this.Description.Add(description, l);
            this.PrimaryMuscleGroup = m1;
        }

        //Equals
        public override bool Equals(object obj)
        {
            var myClass = obj as Exercise;

            if (null != myClass)
            {
                // Order these by the most different first.
                // That is, whatever value is most selective, and the fewest
                // instances have the same value, put that first.
                return this.Name == myClass.Name;
 
            }
            else
            {
                // Not sure this makes sense!
                return base.Equals(obj);
            }
        }
        public override int GetHashCode()
        {
            int hash = 19;
            unchecked
            { // allow "wrap around" in the int
                hash = hash * 31 + this.Name.GetHashCode();

            }
            return hash;
        }
    }
}
