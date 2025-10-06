using WestCoastEducation.Domain;

namespace WestCoastEducation.Application;

public interface ICourseService
{
    void SaveCourse(string patch, Course course);
    Course GetCourse(string path);
}
