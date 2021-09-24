using System;
using Xunit;
using System.Collections.Generic;
using FluentAssertions;

namespace Library.Tests
{
    public class TeacherTest
    {
        [Fact]
        public void Test1()
        {   
            //Tests for correct instantiation
            Teacher teacher = new Teacher("Sally");
            teacher.Should().NotBeNull();
            teacher.Name.Should().Be("Sally");
            
            
        }

    }
}

