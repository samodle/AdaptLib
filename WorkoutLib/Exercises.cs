using System;
using System.Collections.Generic;
namespace AdaptLib
{
    public class Exercise
    {
        #region Variables/Properties
        public Guid ID = new Guid();
        public List<Gear> MyGear { get; set; } = new List<Gear>();

        //for example...
        public AdaptText Name { get; set; }  //...scissor kicks 
        public List<AdaptText> Aliases { get; set; } //...leg crossovers, side to side kicks
        public AdaptText Description { get; set; } //...laying flat on back simultaneuosly kick legs laterally in opposite directions working the lower abdominal muscles
        public AdaptText Instructions { get; set; }  //...more detailed step by step version of 'Description'

        public List<int> Reps { get; set; } = new List<int>();
        public List<TimeSpan> Times { get; set; } = new List<TimeSpan>();
        public List<double> Distances { get; set; } = new List<double>();

        public bool DoIHaveReps { get { return (Reps.Count > 0 && !DoIHaveDistance && !DoIHaveTimes); } }
        public bool DoIHaveTimes { get { return (Times.Count > 0); } }
        public bool DoIHaveDistance { get { return (Distances.Count > 0); } }

        public Tier1Muscle PrimaryMuscleGroup { get; set; }
        public Tier2Muscle SecondaryMuscleGroup { get; set; }

        /* To Do: Add image, adapttext dictionary */
        #endregion

        #region Constructor
        public Exercise(MisIdiomas l, string name, string description, Tier1Muscle m1)
        {
            this.Name.Add(name, l);
            this.Description.Add(description, l);
            this.PrimaryMuscleGroup = m1;
        }
        #endregion


        #region Equals/Hashcode Overrides
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
        #endregion
    }
}
