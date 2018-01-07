using System;
using System.Collections.Generic;
namespace AdaptLib
{
    public class Plan
    {
      //  public int Length{ get { return Days.Count; }}
       // public List<DayOfWork> Days = new List<DayOfWork>();

        public Plan()
        {
          
        }
    }

    public class GymPlan
    {
        public List<GymWork> Gym = new List<GymWork>();
    }
    public class AbPlan
    {
        public List<AbWork> Abs = new List<AbWork>();
    }
    public class AeroPlan
    {
        public List<AeroWork> Cardio = new List<AeroWork>();
    }
}
