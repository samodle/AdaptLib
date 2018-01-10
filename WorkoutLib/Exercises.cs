using System;
using System.Collections.Generic;
namespace AdaptLib
{
    public class Exercise
    {
        #region Variables/Properties
        //public Guid ID = new Guid();
        public static int NumberOfExercises = 1;
        public int ID = -1;
        public List<Gear> MyGear { get; set; } = new List<Gear>();

        public List<int> HarderIDs { get; set; } = new List<int>();
        public List<int> EasierIDs { get; set; } = new List<int>();
        public List<int> AltIDs { get; set; } = new List<int>();

        //for example...
        public AdaptText Name { get; set; } = new AdaptText();  //...scissor kicks 
        public List<AdaptText> Aliases { get; set; } = new List<AdaptText>(); //...leg crossovers, side to side kicks
        public AdaptText Description { get; set; } = new AdaptText(); //...laying flat on back simultaneuosly kick legs laterally in opposite directions working the lower abdominal muscles
        public List<AdaptText> Instructions { get; set; } = new List<AdaptText>();  //...more detailed step by step version of 'Description'. each item in the list is a single instruction/step

        public List<MuscleT1> PrimaryMuscleGroup { get; set; } = new List<MuscleT1>();
        public List<MuscleT2> SecondaryMuscleGroup { get; set; } = new List<MuscleT2>();

        /*
        public List<int> Reps { get; set; } = new List<int>();
        public List<TimeSpan> Times { get; set; } = new List<TimeSpan>();
        public List<double> Distances { get; set; } = new List<double>();

        public bool DoIHaveReps { get { return (Reps.Count > 0 && !DoIHaveDistance && !DoIHaveTimes); } }
        public bool DoIHaveTimes { get { return (Times.Count > 0); } }
        public bool DoIHaveDistance { get { return (Distances.Count > 0); } }
        */


        /* To Do: Add image, adapttext dictionary */
        #endregion

        #region Constructor
        public Exercise(MisIdiomas l, string name,  MuscleT1 m1)
        {
            ID = NumberOfExercises;
            NumberOfExercises++;

            this.Name.Add(name, l);
            this.PrimaryMuscleGroup.Add(m1);
        }
        public Exercise(MisIdiomas l, string name, string description, MuscleT1 m1)
        {
            ID = NumberOfExercises;
            NumberOfExercises++;

            this.Name.Add(name, l);
            this.Description.Add(description, l);
            this.PrimaryMuscleGroup.Add(m1);
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
