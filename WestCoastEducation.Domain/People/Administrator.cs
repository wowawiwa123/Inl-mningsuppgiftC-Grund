namespace WestCoastEducation.Domain;

public class Administrator : EducationLeader
{
    public new string GetInfo()
    {
        return $"{FirstName} {LastName}  (Managing: {ResponsibleCourses})";
    }
}
