
namespace WestCoastEducation.App;

using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using WestCoastEducation.Application;
using WestCoastEducation.Domain;
using WestCoastEducation.Persistent;

class Program
{
    static void Main()
    {
        var storage = new JsonStorage();
        var courseService = new CourseService(storage);
        var path = $"{Environment.CurrentDirectory}/Data/courses.json";


        var student1 = new Student()
        {
            FirstName = "Patrik",
            LastName = "Sjöstjärna",
            Adress = "Wrangelsvägen 89A",
            PostalCode = "245-53",
            PersonalIdentityNumber = "1123-311"
        };
        var student2 = new Student()
        {
            FirstName = "Spongebob",
            LastName = "Squarepants",
            Adress = "Wrangelsvägen 87A",
            PostalCode = "245-53",
            PersonalIdentityNumber = "2232-112"
        };
        var student3 = new Student()
        {
            FirstName = "Wendy",
            LastName = "Squirrel",
            Adress = "Bamsamgatan 55A",
            PostalCode = "776-32",
            PersonalIdentityNumber = "7782-312"
        };

        var course = new Course();
        var course1 = new Course()
        {
            CourseId = "1111",
            Title = "Math",
            CourseLength = "2 months",
            StartDate = new DateTime(2025, 01, 30),
            EndDate = new DateTime(2025, 03, 30),
            Type = CourseType.Remote
        };
        var course2 = new Course()
        {
            CourseId = "1112",
            Title = "Science",
            CourseLength = "4 months",
            StartDate = new DateTime(2025, 01, 30),
            EndDate = new DateTime(2025, 05, 22),
            Type = CourseType.Remote
        };
        var course3 = new Course()
        {
            CourseId = "1113",
            Title = "English",
            CourseLength = "6 months",
            StartDate = new DateTime(2025, 01, 30),
            EndDate = new DateTime(2025, 07, 12),
            Type = CourseType.Remote
        };

        courseService.AddStudentToCourse(course1, student1);
        courseService.AddStudentToCourse(course1, student2);
        courseService.ShowCourseInfo(course1);
        courseService.SaveCourse(path, course1);
        courseService.GetCourse(path);
        
    }
    
    

}
