using System;
using System.Collections.Generic;
namespace Library
{

    public class Admin
    {
        public string Name;
        public Admin(string name)
        {
            this.Name = name;
        }

        public void AddTeacher(string teacherName, College college)
        {
            college.Teachers.Add(new Teacher(teacherName));
        }

        public List<Teacher> ViewTeachers(College college)
        {

            return college.Teachers;
        }

    }
}