using System;
using System.Collections.Generic;
namespace AdaptLib
{
    public class DailyPlan
    {
        public int DayNumber { get; set; } = -1; //ToDo?
        public bool isOff { get; set; }
        public List<Workout> Workouts { get; set; }

        public List<Gear> Equipment { get; set; } //populated from Workouts

        public DailyPlan()
        {
            Workouts = new List<Workout>();
            Equipment = new List<Gear>();
            isOff = true;
        }


        public DailyPlan(List<Workout> work)
        {
            isOff = false;
            Workouts = work;
            setGearFromWork();
        }

        private void setGearFromWork()
        {

        }
    }

    public class WorkoutPlan
    {
        public List<DailyPlan> Days = new List<DailyPlan>();
    }
}
