using System.Security.Cryptography.X509Certificates;

namespace WestCoastEducation.Domain;

public class Course : IInfo
{
    public string CourseId { get; set; } = "";
    public string Title { get; set; } = "";
    public string CourseLength { get; set; } = "";
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public CourseType Type { get; set; }

    private readonly List<Student> students = new();
    public List<Student> Students => students;

    private readonly List<Teacher> teachers = new();
    public  List<Teacher> Teachers => teachers;


    public bool AddStudent(Student studentToAdd)
    {
        if (students.Any(student => student.PersonalIdentityNumber == studentToAdd.PersonalIdentityNumber))
        {
            return false;
        }
        else
        {
            students.Add(studentToAdd);       
            return true;
        }
    }

    public bool AddTeacher(Teacher teacherToAdd)
    {
        if (teachers.Any(teacher => teacher.PersonalIdentityNumber == teacherToAdd.PersonalIdentityNumber))
        {
            return false;
        }
        else
        {
            teachers.Add(teacherToAdd);
            return true;
        }
    }
    public string GetInfo()
    {
        return $"Course: {Title} ({CourseId}), Length: {CourseLength}, Type: {Type}, Students: {students.Count}, Teachers: {teachers.Count}";
    }
    
}
