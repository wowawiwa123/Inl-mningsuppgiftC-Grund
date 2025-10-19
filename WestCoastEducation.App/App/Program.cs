namespace WestCoastEducation.App;

using WestCoastEducation.Application;
using WestCoastEducation.Domain;
using WestCoastEducation.Persistent;

class Program
{
    static void Main()
    {
        var storage = new JsonStorage();
        var jsonService = new JsonService(storage);
        var courseService = new CourseService();
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

        var teacher1 = new Teacher()
        {
            FirstName = "Wendy",
            LastName = "Squirrel",
            Adress = "Bamsamgatan 55A",
            PostalCode = "776-32",
            PersonalIdentityNumber = "7782-312",
            AreaOfKnowledge = "Math - PE - Art",
            ResponsibleCourses = "Math"
        };

        var teacher2 = new Teacher()
        {
            FirstName = "Sally",
            LastName = "Burnes",
            Adress = "TimTam 55A",
            PostalCode = "236-32",
            PersonalIdentityNumber = "5552-312",
            AreaOfKnowledge = "English",
            ResponsibleCourses = "English"
        };

        var educationLeader1 = new EducationLeader()
        {
            FirstName = "Bambi",
            LastName = "Squirrel",
            Adress = "Bamsamgatan 55A",
            PostalCode = "776-32",
            PersonalIdentityNumber = "7782-555",
            AreaOfKnowledge = "Math - PE - Art",
            ResponsibleCourses = "Math",
            DateOfEmployment = new DateTime(2001, 07, 30)
        };
        var educationLeader2 = new EducationLeader()
        {
            FirstName = "Alex",
            LastName = "Wendell",
            Adress = "Logitexh 55A",
            PostalCode = "886-32",
            PersonalIdentityNumber = "4244-422",
            AreaOfKnowledge = "Language courses",
            ResponsibleCourses = "English - Spanish - German",
            DateOfEmployment = new DateTime(2001, 07, 30)
        };

        var administrator1 = new Administrator()
        {
            FirstName = "Lars",
            LastName = "Olof",
            Adress = "Vänersborgsgatan 13",
            PostalCode = "662-32",
            PersonalIdentityNumber = "0101-898",
            ResponsibleCourses = "Science fields",
            DateOfEmployment = new DateTime(1992, 07, 30)
        };
        var administrator2 = new Administrator()
        {
            FirstName = "Bengt",
            LastName = "Gustavsson",
            Adress = "Vänersborgsgatan 13",
            PostalCode = "662-32",
            PersonalIdentityNumber = "0101-444",
            ResponsibleCourses = "Science fields",
            DateOfEmployment = new DateTime(1992, 07, 30)
        };

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

        var courses = new List<Course>();
        if (File.Exists(path))
        {
            courses = jsonService.GetCourse(path);
        }

        courseService.AddStudentToCourse(course1, student1);
        courseService.AddStudentToCourse(course1, student2);
        courseService.AddTeacherToCourse(course1, teacher1);
        courseService.AddEducationLeaderToCourse(course1, educationLeader1);
        courseService.AddAdministratorToCourse(course1, administrator1);
        courseService.ShowCourseInfo(course1); 

        courseService.AddStudentToCourse(course3, student1);
        courseService.AddStudentToCourse(course3, student2);
        courseService.AddTeacherToCourse(course3, teacher2);
        courseService.AddEducationLeaderToCourse(course3, educationLeader2);
        courseService.AddAdministratorToCourse(course3, administrator2);
        courseService.ShowCourseInfo(course3); 


        courses.Add(course1);
        courses.Add(course2);
        courses.Add(course3);
        jsonService.SaveCourse(path, courses);

    }
}
