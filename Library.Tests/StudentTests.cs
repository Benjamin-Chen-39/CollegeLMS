using System;
using Xunit;
using System.Collections.Generic;
using FluentAssertions;

namespace Library.Tests
{
    public class StudentTest
    {
        [Fact]
        public void Test1()
        {   
            //Tests for correct instantiation
            Student student = new Student("Bob");
            student.Should().NotBeNull();
            student.Name.Should().Be("Bob");
            
            
        }

    }
}
