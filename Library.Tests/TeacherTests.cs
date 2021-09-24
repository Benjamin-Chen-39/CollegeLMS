using System;
using Xunit;
using System.Collections.Generic;
using FluentAssertions;

namespace Library.Tests
{
    public class TeacherTest
    {

        public Course TestCourse;
        public Teacher TestTeacher;
        public TeacherTest()
        {
            TestCourse = new Course("Test Course");
            TestCourse.Roster.Add("Test Student");
            TestTeacher = new Teacher("Test Teacher");
        }


        [Fact]
        public void Test1()
        {
            //Tests for correct instantiation
            Teacher teacher = new Teacher("Sally");
            teacher.Should().NotBeNull();
            teacher.Name.Should().Be("Sally");
        }

        [Fact]
        public void Test2()
        {
            //Teacher should create new test for a course
            TestTeacher.AddExam(TestCourse);
            TestCourse.Exams.Should().HaveCount(1);
        }

        [Fact]
        public void Test3()
        {
            //Teacher should grade exams
            TestTeacher.AddExam(TestCourse);
            // fake input
            int ExamNumber = 1;
            string TestStudent = "Test Student";
            int ExamGrade = 100;
            TestTeacher.GradeExam(TestCourse.Exams[ExamNumber - 1], TestStudent, ExamGrade);
            TestCourse.Exams[0].ExamGrades["Test Student"].Should().Be(100);
        }

        [Fact]
        public void Test4()
        {
            //Teacher should get average score for one student
            TestTeacher.AddExam(TestCourse);
            TestTeacher.AddExam(TestCourse);
            TestTeacher.AddExam(TestCourse);
            // fake input
            string TestStudent = "Test Student";
            TestTeacher.GradeExam(TestCourse.Exams[0], TestStudent, 70);
            TestTeacher.GradeExam(TestCourse.Exams[1], TestStudent, 100);
            TestTeacher.GradeExam(TestCourse.Exams[2], TestStudent, 37);
            TestTeacher.GetStudentAverage(TestCourse.Exams, TestStudent).Should().Be(Convert.ToDecimal(69));

        }
    }
}

