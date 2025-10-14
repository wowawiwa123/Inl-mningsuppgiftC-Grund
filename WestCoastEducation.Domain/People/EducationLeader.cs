namespace WestCoastEducation.Domain;

public class EducationLeader : Teacher, IInfo
{
    public DateTime DateOfEmployment { get; set; }

    public new string GetInfo()
    {
        return $"{FirstName} {LastName} (Teaching: {AreaOfKnowledge}) (Managing: {ResponsibleCourses}) (Employed since: {DateOfEmployment})";
    }
}

