using System;
using System.Collections.Generic;
using System.Linq;
namespace Library
{

    public class Teacher
    {
        public string Name;
        public Teacher(string name)
        {
            this.Name = name;
        }
        public override string ToString() => $"{Name}";


        public void AddExam(Course course)
        {
            course.Exams.Add(new Exam(course.Roster));
        }

        public void GradeExam(Exam exam, string TestStudent, int examGrade)
        {
            exam.ExamGrades[TestStudent] = examGrade;
        }

        public decimal GetStudentAverage(List<Exam> examList, string studentName)
        {
            decimal studentAverage = 0;
            examList.ForEach(exam => studentAverage += exam.ExamGrades[studentName]);
            return decimal.Divide(studentAverage, Convert.ToDecimal(examList.Count()));
        }

        public decimal GetCourseAverage(List<Exam> examList)
        {
            List<int> allGrades = new List<int>();
            examList.ForEach(exam => allGrades.AddRange(exam.ExamGrades.Values.ToList()));
            return Convert.ToDecimal(allGrades.Sum() / allGrades.Count());
        }

        public decimal GetCourseMedian(List<Exam> examList)
        {
            List<int> allGrades = new List<int>();
            examList.ForEach(exam => allGrades.AddRange(exam.ExamGrades.Values.ToList()));
            allGrades.OrderBy(grades => grades);
            return allGrades[allGrades.Count / 2];
        }
    }

}