using System;
using Xunit;
using System.Collections.Generic;
using FluentAssertions;

namespace Library.Tests
{
    public class ExamTest
    {
        [Fact]
        public void Test1()
        {   
            //Tests for passing in a roster of students
            List<string> roster = new List<string>(){"Bob", "Sally", "Jake"};
            Exam test = new Exam(roster);
            test.ExamGrades.Should().HaveCount(3);
        }

        [Fact]
        public void Test2()
        {   
            //Test to check names of students 
            List<string> roster = new List<string>(){"Bob", "Sally", "Jake"};
            Exam test = new Exam(roster);
            test.ExamGrades.Should().Contain("Sally",69);
         

        }
    }
}
