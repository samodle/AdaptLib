using System;
using System.Collections.Generic;
namespace AdaptLib
{
    public class Plan
    {
        public List<Workout> Workouts = new List<Workout>();

        public List<Gear> Equipment = new List<Gear>(); //populated from Workouts


        public Plan()
        {
          
        }
    }

    public class WorkoutPlan
    {
        public List<DailyPlan> Days = new List<DailyPlan>();
    }

    public class DailyPlan:Plan
    {

    }
}
