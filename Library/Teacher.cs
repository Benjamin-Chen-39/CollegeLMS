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
            decimal total = 0;
            examList.ForEach(exam => total += exam.ExamGrades[studentName]);
            return decimal.Divide(total, Convert.ToDecimal(examList.Count()));
        }
    }

}