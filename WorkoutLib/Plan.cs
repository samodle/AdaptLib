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
            foreach(Workout w in Workouts)
            {
                //?
            }
        }
    }

    public class WorkoutPlan
    {
        public AdaptText Name { get; set; } 
        public List<DailyPlan> Days { get; set; } = new List<DailyPlan>();

        public WorkoutPlan(MisIdiomas lang, string nombre)
        {
            Name = new AdaptText(nombre, lang);
        }
    }
}
