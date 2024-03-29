﻿using System;
namespace AdaptLib
{
    //workout specific
    // public enum TorsoPositionT1 { standing_upright, sitting, kneeling, laying}
    // public enum LegPositionT1 { }
    public enum SetType { rep, Tsec, Tmin, distMi, distKm, distM, NA }

    public enum WorkoutType { superset, fortime, NA }

    public enum MuscleT1 { arms, legs, chest, neck, back, core }

    public enum MuscleT2 { biceps, triceps, forearms }

    public enum WorkoutEquipment { barbell, dumbell, speedladder, mat, plyobox, propbox, chair, footprop, soupcans }

    public enum WeightStatus { none, optional, preferred, required }

    //other
    public enum UnitType { metric, imperial }

    public enum MisIdiomas { EN, espanol, francais, korean }  //english technical (isometric etc), englishAlt
}
