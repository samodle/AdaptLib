using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptLib
{
    public class WorkoutStructure
    {
        #region Variables/Properties
        //defines the set and/or superset structure of the workout. ints are indexes of the workout in the exercise list
        //Tuple<workout index, amount, type>
        public List<List<Tuple<int, double, SetType>>> SetList { get; private set; } = new List<List<Tuple<int, double, SetType>>>();

        public WorkoutType WType { get; set; } = WorkoutType.superset;

        public bool DoIHaveTimes { get; private set; } = false;
        public bool DoIHaveDistances { get; private set; } = false;
        public bool DoIHaveReps { get; set; } = false;
        #endregion

        public void addSets(List<int> sets, List<double> data, List<SetType> types, int n)
        {
            List<Tuple<int, double, SetType>> x = new List<Tuple<int, double, SetType>>();
            for (int i = 0; i < sets.Count; i++)
            {
                x.Add(new Tuple<int, double, SetType>(sets[i], data[i], types[i]));
            }
            for (int i = 0; i < n; i++)
            {
                SetList.Add(x);
            }
        }

        public void addSetsAndReps(List<int> sets, List<double> reps, int n)
        {
            if (sets.Count != reps.Count)
            {
                throw new Exception(TheSourceCode.RandoErrorMessageOpener() + " Set list and rep list have different counts!");
            } //err

            List<Tuple<int, double, SetType>> x = new List<Tuple<int, double, SetType>>();
            for (int i = 0; i < sets.Count; i++)
            {
                x.Add(new Tuple<int, double, SetType>(sets[i], reps[i], SetType.rep));
            }
            for (int i = 0; i < n; i++)
            {
                SetList.Add(x);
            }
            DoIHaveReps = true;
        }

        public void addSetsAndTimes(List<int> sets, List<double> times, int n, SetType st)
        {
            if (sets.Count != times.Count) { throw new Exception("HOLY SMOKES! Time list and set list have different counts - this ain't gonna work!"); } //err
            List<Tuple<int, double, SetType>> x = new List<Tuple<int, double, SetType>>();
            for (int i = 0; i < sets.Count; i++)
            {
                x.Add(new Tuple<int, double, SetType>(sets[i], times[i], st));
            }
            for (int i = 0; i < n; i++)
            {
                SetList.Add(x);
            }
        }

        public void addSetsAndReps(List<int> sets, List<double> reps)
        {
            addSetsAndReps(sets, reps, n: 1);
        }

        public WorkoutStructure(bool anyTimes, bool anyDistances)
        {
            if (anyTimes)
            {
                DoIHaveTimes = true;
            }
            if (anyDistances)
            {
                DoIHaveDistances = true;
            }
        }
    }
}
