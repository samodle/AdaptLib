using System;
using System.Collections.Generic;
using System.Linq;
namespace AdaptLib
{
    public class Work
    {
        #region Variables/Properties

        public List<Exercise> Exercizes { get; set; } = new List<Exercise>();
        #endregion

    }



    public class GymWork
    {

        #region Variables/Properties
        public AdaptText Name { get; set; }
        public int NumRounds { get; set; } = 0; //works w/ constructor
        public List<List<int>> NumReps { get; set; } = new List<List<int>>();
        public List<Exercise> Exercizes { get; set; } = new List<Exercise>();
        #endregion

        public void AddWork(Exercise e, int rounds, List<int> reps)
        {
            NumRounds++;
            Exercizes.Add(e);
            NumReps.Add(reps);
        }

        public GymWork()
        {
        }
    }

    public class AbWork
    {
        #region Variables/Properties
        public AdaptText Name { get; set; }

        public List<Exercise> Exercizes { get; private set; } = new List<Exercise>();

        public TimeSpan Duration { get; set; } //cumulative timespan of exercize duration 

        public List<Gear> EquipmentRequired { get; set; } = new List<Gear>();
        #endregion

        private void SetGear()
        {
            EquipmentRequired.Clear();
            foreach (Exercise e in Exercizes)
            {
                foreach (Gear g in e.MyGear)
                    if (!EquipmentRequired.Contains(g))
                    {
                        EquipmentRequired.Add(g);
                    }
            }
        }
    }

    public class AeroWork { }
}
