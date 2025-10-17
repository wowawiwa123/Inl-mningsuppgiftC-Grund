namespace WestCoastEducation.Domain;

public class Administrator : EducationLeader
{
    public override string ToString()
    {
        return $"{FirstName} {LastName}  (Managing: {ResponsibleCourses})";
    }
}
