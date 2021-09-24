using System;
using Xunit;
using System.Collections.Generic;
using FluentAssertions;

namespace Library.Tests
{
    public class CourseTest
    {
        [Fact]
        public void Test1()
        {
            //Tests for correct instantiation
            Course test = new Course("Calculus");
            test.Should().NotBeNull();
            test.Capacity.Should().Be(30);
            test.Name.Should().Be("Calculus");
            test.Seats[0, 0].Should().Be(false);
            test.Seats[4, 5].Should().Be(false);
            test.Roster.Should().BeEmpty();
            test.Exams.Should().BeEmpty();
        }
    }
}
