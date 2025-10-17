namespace WestCoastEducation.Domain;

public class Teacher : Person 
{
    public string AreaOfKnowledge { get; set; } = "";
    public string ResponsibleCourses { get; set; } = "";



    public override string ToString()
    {
        return $"{FirstName} {LastName} (Teaching: {AreaOfKnowledge}) (Managing: {ResponsibleCourses})";
    }
}
