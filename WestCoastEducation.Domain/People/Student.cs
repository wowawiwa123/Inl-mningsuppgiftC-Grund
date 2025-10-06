namespace WestCoastEducation.Domain;

public class Student : Person , IInfo
{
    public string GetInfo()
    {
        return $"{FirstName} {LastName} (ID: {PersonalIdentityNumber})";
    }
}
