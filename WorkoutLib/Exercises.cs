using System;
using System.Collections.Generic;
namespace AdaptLib
{
    public class ExerciseParams
    {
        public MuscleT1 PrimaryMuscle { get; set; }
        public WeightStatus WeightStat { get; set; }


        public ExerciseParams(MuscleT1 m1, WeightStatus w)
        {
            WeightStat = w;
            PrimaryMuscle = m1;
        }
    }

    public class Exercise
    {
        #region Variables/Properties
        //public Guid ID = new Guid();
        public static int NumberOfExercises = 1;
        public int ID = -1;
        public List<int> MyGear { get; set; } = new List<int>();

        public List<int> HarderIDs { get; set; } = new List<int>();
        public List<int> EasierIDs { get; set; } = new List<int>();
        public List<int> AltIDs { get; set; } = new List<int>();

        public WeightStatus WeightsNeeded { get; set; }

        //for example...
        public AdaptText Name { get; set; } = new AdaptText();  //...scissor kicks 
        public List<AdaptText> Aliases { get; set; } = new List<AdaptText>(); //...leg crossovers, side to side kicks
        public AdaptText Description { get; set; } = new AdaptText(); //...laying flat on back simultaneuosly kick legs laterally in opposite directions working the lower abdominal muscles
        public List<AdaptText> Instructions { get; set; } = new List<AdaptText>();  //...more detailed step by step version of 'Description'. each item in the list is a single instruction/step

        public List<MuscleT1> PrimaryMuscleGroup { get; set; } = new List<MuscleT1>();
        public List<MuscleT2> SecondaryMuscleGroup { get; set; } = new List<MuscleT2>();

        /* To Do: Add image, adapttext dictionary */
        #endregion

        #region Constructor
        public Exercise(ExerciseParams p, MisIdiomas l, string name)
        {
            ID = NumberOfExercises;
            NumberOfExercises++;

            this.Name.Add(name, l);
            this.PrimaryMuscleGroup.Add(p.PrimaryMuscle);
        }
        public Exercise(ExerciseParams p, MisIdiomas l, string name, string description) : this(p, l, name)
        {
            this.Description.Add(description, l);
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
