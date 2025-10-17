namespace WestCoastEducation.Domain;

public class Student : Person 
{
    public override string ToString()
    {
        return $"{FirstName} {LastName} (ID: {PersonalIdentityNumber})";
    }
}
