namespace WestCoastEducation.Application;

using System.Threading.Tasks.Dataflow;
using WestCoastEducation.Domain;
using WestCoastEducation.Persistent;

public class CourseService 
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
    public void AddEducationLeaderToCourse(Course course, EducationLeader educationLeader)
    {
        if (course.AddEducationLeader(educationLeader))
        {
            Console.WriteLine("EducationLeader has been added!");

        }
        else
        {
            Console.WriteLine("EducationLeader is already in the system");
        }
    }
    public void AddAdministratorToCourse(Course course, Administrator administrator)
    {
        if (course.AddAdminstrator(administrator))
        {
            Console.WriteLine("Administrator has been added!");

        }
        else
        {
            Console.WriteLine("Administrator is already in the system");
        }
    }
    public void ShowCourseInfo(Course course)
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
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
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("|--------------------|");
            
        }

        if (course.Teachers.Count == 0)
        {
            Console.WriteLine("No teacher assigned to this course!");
        }
        else
        {
            Console.WriteLine("Designated Teacher: ");
            foreach (var teacher in course.Teachers)
            {
                Console.WriteLine(teacher);
            }
            Console.WriteLine("|--------------------|");
        }

        if (course.EducationLeaders.Count == 0)
        {
            Console.WriteLine("No educationLeader assigned to this course!");
        }
        else
        {
            Console.WriteLine("Educationleader:");
            foreach (var educationLeader in course.EducationLeaders)
            {
                Console.WriteLine(educationLeader);
            }
            Console.WriteLine("|--------------------|");
        }

        if (course.Administrators.Count == 0)
        {
            Console.WriteLine("No Administrator assigned to this course!");
        }
        else
        {
            Console.WriteLine("Administrator:");
            foreach (var administrator in course.Administrators)
            {
                Console.WriteLine(administrator);
            }
            Console.WriteLine("|--------------------|");
        }
        
    }


//     public void ListStudents(Course course)
// {
//     if (course.Students.Count == 0)
//     {
//         Console.WriteLine("No students enrolled!");
//     }
//     else
//     {
//         foreach (var student in course.Students)
//             Console.WriteLine(student);
//     }
// }


//     public void ListTeachers(Course course)
//     {
//         if (course.Teachers.Count == 0)
//         {
//             Console.WriteLine("No teachers assigned!");
//         }
//         else
//         {
//             foreach (var teacher in course.Teachers)
//                 Console.WriteLine(teacher);
//         }
//     }



}
