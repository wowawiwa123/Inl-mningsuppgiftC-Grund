namespace WestCoastEducation.Domain;

public class EducationLeader : Teacher
{
    public DateTime DateOfEmployment { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}  (Employed since: {DateOfEmployment: yyyy-MM-dd})";
    }
}

