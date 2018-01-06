using System.Collections.Generic;
using System.Linq;
namespace AdaptLib
{
    public class GymWork
    {
        public AdaptText Name { get; set; }
        public int NumRounds { get; set; } = 0; //works w/ constructor
        public List<List<int>> NumReps { get; set; } = new List<List<int>>();
        public List<Exercise> Exercizes { get; set; } = new List<Exercise>();

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
        public AdaptText Name { get; set; }

        public List<Exercise> Exercizes { get; set; } = new List<Exercise>();
        public List<double> Seconds { get; set; } = new List<double>();

        public double NetSeconds { get { return Seconds.Sum(); } }
        public double NetMinutes { get { return NetSeconds / 60; } }

        public List<Gear> EquipmentRequired { get; set; } = new List<Gear>();

        public void AddWork(Exercise e, double s)
        {
            Exercizes.Add(e);
            Seconds.Add(s);
        }

        private void SetGear()
        {
            EquipmentRequired.Clear();
            foreach (Exercise e in Exercizes)
            {
                foreach(Gear g in e.MyGear)
                if (!EquipmentRequired.Contains(g))
                {
                    EquipmentRequired.Add(g);
                }
            }
        }

    }

    public class AeroWork { }

}
