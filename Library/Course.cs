using System;
using System.Collections.Generic;

namespace Library
{
   
    public struct Course
    {   public string Name;
        public int Capacity; 
        public bool[,] Seats; //true = taken 
        public bool Open; // true = open
        public List<string> Roster;
        public List<Exam> Exams; 

        public Course(string name)
        {   this.Name = name;
            this.Capacity = 30;  
            this.Seats = new bool[5,6];
            this.Open = true; 
            this.Roster = new List<string>();
            this.Exams = new List<Exam>();
        }
           
    }
    
}