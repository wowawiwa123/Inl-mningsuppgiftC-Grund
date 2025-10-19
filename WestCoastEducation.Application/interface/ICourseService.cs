using WestCoastEducation.Domain;

namespace WestCoastEducation.Application;

public interface ICourseService
{
    void SaveCourse(string patch, List<Course> course);
    List<Course> GetCourse(string path);
}
