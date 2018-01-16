using System;
using System.Collections.Generic;
using System.Text;

namespace AdaptLib
{
    public class WorkoutStructure
    {
        #region Variables/Properties
        //defines the set and/or superset structure of the workout. ints are indexes of the workout in the exercise list
        public List<List<int>> SetList { get; set; } = new List<List<int>>();
        public List<List<int>> RepList { get; set; } = new List<List<int>>();
        public List<List<double>> TimeList { get; set; }// = new List<List<double>>(); //MINUTES
        public List<List<double>> DistList { get; set; }// = new List<List<double>>();

        public bool DoIHaveTimes { get; private set; } = false;
        public bool DoIHaveDistances { get; private set; } = false;
        public bool TimesAreInMinutes { get; set; } = true;        
        #endregion
 
        public void addSetsAndReps(List<int> sets, List<int> reps, int n)
        {
            for(int i = 0; i < n; i++)
            {
                SetList.Add(sets);
                RepList.Add(reps);
            }
        }

        public void addSetsAndTimes(List<int> sets, List<double> times, int n)
        {
            for (int i = 0; i < n; i++)
            {
                SetList.Add(sets);
                TimeList.Add(times);
            }
        }

        public void addSetsAndReps(List<int> sets, List<int> reps)
        {
            addSetsAndReps(sets, reps, n: 1);
        }

        public WorkoutStructure(bool anyTimes, bool anyDistances)
        {
            if (anyTimes)
            {
                DoIHaveTimes = true;
                TimeList = new List<List<double>>();
            }
            if (anyDistances)
            {
                DoIHaveDistances = true;
                DistList = new List<List<double>>();
            }
        }
    }
}
