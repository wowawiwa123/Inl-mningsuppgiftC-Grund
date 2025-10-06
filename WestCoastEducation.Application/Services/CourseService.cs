namespace WestCoastEducation.Application;

using System.Text.Encodings.Web;
using System.Text.Json;
using WestCoastEducation.Domain;
using WestCoastEducation.Persistent;

public class CourseService : ICourseService
{
    public void AddStudentToCourse(Course course, Student student)
    {
        if (course.AddStudent(student))
        {
            Console.WriteLine("Student has been added!");
        }
        else
        {
            Console.WriteLine("Student is already enrolled!");
        }
    }

    public void AddTeacherToCourse(Course course, Teacher teacher)
    {
        if (course.AddTeacher(teacher))
        {
            Console.WriteLine("Teacher has been added!");

        }
        else
        {
            Console.WriteLine("Teacher is already in the system");
        }
    }
    public void ShowCourseInfo(Course course)
    {
        Console.WriteLine("-------Course Information -------");
        Console.WriteLine($"Course ID: {course.CourseId}");
        Console.WriteLine($"Subject: {course.Title}");
        Console.WriteLine($"Type: {course.Type}");
        Console.WriteLine($"Start Date: {course.StartDate: yyyy-MM-dd}");
        Console.WriteLine($"End Date: {course.EndDate: yyyy-MM-dd}");
        Console.WriteLine($"Length: {course.CourseLength}");    
        Console.WriteLine("---------------------");

        if (course.Students.Count == 0)
        {
            Console.WriteLine("No enrolled students in this course");
        }
        else
        {
            Console.WriteLine("Enrolled Students: ");
            foreach (var student in course.Students)
                Console.WriteLine(student);
                
        }

        if (course.Teachers.Count == 0)
        {
            Console.WriteLine("No teacher assigned to this course!");
        }
        else
        {
            Console.WriteLine("Designated Teacher: ");
            foreach (var teacher in course.Teachers)
                Console.WriteLine(teacher);
        }
    }


    public void ListStudents(Course course)
{
    if (course.Students.Count == 0)
    {
        Console.WriteLine("No students enrolled!");
    }
    else
    {
        foreach (var student in course.Students)
            Console.WriteLine(student);
    }
}


    public void ListTeachers(Course course)
    {
        if (course.Teachers.Count == 0)
        {
            Console.WriteLine("No teachers assigned!");
        }
        else
        {
            foreach (var teacher in course.Teachers)
                Console.WriteLine(teacher);
        }
    }


    private readonly IStorage _storage;

    public CourseService(IStorage storage)
    {
        _storage = storage;
    }
    private static JsonSerializerOptions _options = new()
    {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true
    };
    public void SaveCourse(string path, Course course)
    {
        string json = JsonSerializer.Serialize(course, _options);
        _storage.Write(path, json);
    }

    public Course GetCourse(string path)
    {
        _options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var json = _storage.Read(path);
        Console.WriteLine(json);

        var course = JsonSerializer.Deserialize<Course>(json, _options);

        return course ?? new Course();
    }
}
