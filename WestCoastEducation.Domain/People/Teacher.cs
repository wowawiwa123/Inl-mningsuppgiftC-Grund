namespace WestCoastEducation.Domain;

public class Teacher : Person , IInfo
{
    public string AreaOfKnowledge { get; set; } = "";
    public string ResponsibleCourses { get; set; } = "";



    public string GetInfo()
    {
        return $"{FirstName} {LastName} (Teaching: {AreaOfKnowledge}) (Managing: {ResponsibleCourses})";
    }
}
