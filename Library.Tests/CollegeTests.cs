using System;
using Xunit;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FluentAssertions;

namespace Library.Tests
{
    public class CollegeTest
    {
        [Fact]
        public void Test1()
        {   
            //Tests for correct data from api*
            College college = new College();
            college.CourseNames.Should().HaveCount(16);
            college.CourseNames.Should().Contain( "Calculus",
                "Linear Algebra",
                "Probability",
                "Statistics",
                "Physics",
                "Biology",
                "Chemistry",
                "Electrical Engineering",
                "Computer Science",
                "Art",
                "Film",
                "Music",
                "Dance",
                "Literature",
                "Philosophy",
                "World History");
            college.Courses.Should().NotBeEmpty().And.HaveCount(16);
          
        }

      
    }
}
