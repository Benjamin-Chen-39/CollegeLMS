using System;
using Xunit;
using System.Collections.Generic;
using FluentAssertions;

namespace Library.Tests
{
    public class AdminTest
    {
        College testCollege;
        public AdminTest()
        {
            this.testCollege = new College();
        }

        [Fact]
        public void Test1()
        {
            //Tests for correct instantiation
            Admin admin = new Admin("BobAdmin");
            admin.Should().NotBeNull();
            admin.Name.Should().Be("BobAdmin");
        }

        [Fact]
        public void Test2()
        {
            //should succesfully create/add a teacher
            Admin admin = new Admin("BobAdmin");
            admin.Should().NotBeNull();
            admin.Name.Should().Be("BobAdmin");
            admin.AddTeacher("NewTeacher", testCollege);
            testCollege.Teachers.Should().NotBeEmpty().And.ContainItemsAssignableTo<Teacher>(); ;
        }

        [Fact]
        public void Test3()
        {
            //should succesfully view all teachers
            Admin admin = new Admin("BobAdmin");
            admin.Should().NotBeNull();
            admin.Name.Should().Be("BobAdmin");
            admin.AddTeacher("NewTeacher", testCollege);
            admin.ViewTeachers(testCollege).Should().BeOfType<List<Teacher>>();
        }

    }
}
