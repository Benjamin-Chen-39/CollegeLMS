using System;
using System.Collections.Generic;
namespace Library
{

    public struct Exam
    {
        public Dictionary<string, int> ExamGrades;
        public Exam(List<string> roster)
        {
            this.ExamGrades = new Dictionary<string, int>();
            foreach (var s in roster)
                ExamGrades.Add(s, 69);
        }
    }
}