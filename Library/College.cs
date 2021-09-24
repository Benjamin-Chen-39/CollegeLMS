using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Library
{
    
    public class College 
    {
        public List<Course> Courses;
        public List<Teacher> Teachers;
        public List<String> CourseNames;

        public College ()
        {
            this.Teachers = new List<Teacher>();
            this.Courses = new List<Course>(); 
            this.CourseNames = GetDataFromHttp().GetAwaiter().GetResult();
            foreach(var c in CourseNames)
            this.Courses.Add(new Course(c));
         
        }

          public static async Task<List<string>> GetDataFromHttp()
        {
                var client = new HttpClient();
                var CourseNames = await client.GetFromJsonAsync<List<string>>("https://raw.githubusercontent.com/chyld/datasets/main/subjects.json");
                return CourseNames;
        }

    }

   
}