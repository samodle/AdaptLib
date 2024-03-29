﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace AdaptLib
{
    public class Burst
    {
        #region Variables/Properties
        public static int NetCount = 1; //static int to track total number of these objects in order to generate IDs
        public int ID { get; set; } = -1;
        public AdaptText Name { get; set; } = new AdaptText();
        public List<int> Exercises { get; set; } = new List<int>();
        #endregion
    }


    public class Workout
    {
        #region Variables/Properties
        public static int NetCount = 1; //static int to track total number of these objects in order to generate IDs
        public int ID { get; set; } = -1;
        public AdaptText Name { get; set; } = new AdaptText();
        public AdaptText Description { get; set; } = new AdaptText();
        public AdaptText Instructions { get; set; } = new AdaptText();

        public double Target { get; private set; } = -1;
        public SetType TargetType { get; private set; } = SetType.NA;


        /*
         * 1. the order of this list is CRITICAL for the operation of the SetList set/superset functionality
         * 2. Exercizes and Equip/Gear lists need to be populated at the same time
         */
        public List<int> Exercises { get; set; } = new List<int>();

        public WorkoutStructure Sets { get; set; }

        /*
         *should be populated when the exercize list is populated as this is set from that list
         */
        public List<int> Equip { get; private set; }
        #endregion

        public override string ToString()
        {
            return "ID: " + ID.ToString() + ", EquipList.Count = " + Equip.Count;
        }

        public void setTargetAndType(double trgt, SetType stype)
        {
            Target = trgt;
            TargetType = stype;
        }

        private void populateEquipmentList()
        {
            foreach (int e in Exercises)
            {
             /*   foreach (int g in e.MyGear)
                {
                    if (!Equip.Contains(g)) { Equip.Add(g); }
                }  */
            }
        }

        #region Constructor
        public Workout(MisIdiomas lang, string name)
        {
            ID = NetCount;

            Name.Add(name, lang);

            NetCount++;
        }

        public Workout(MisIdiomas lang, string name, string description): this(lang, name)
        {
            this.Description.Add(description, lang);
        }

        public Workout(MisIdiomas lang, string name, string description, string instruct): this(lang, name, description)
        {
            if(instruct == "")
            {
                Instructions.Add("Perform each exercise at high intensity for the prescribed sets and repetitions to complete one round.", MisIdiomas.EN);
            }
            else
            {
                Instructions.Add(instruct, lang);
            }           
        }
        #endregion
    }
}