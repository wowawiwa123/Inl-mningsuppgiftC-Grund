namespace WestCoastEducation.Domain;

public abstract class Person 
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Adress { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string PersonalIdentityNumber { get; set; } = "";


    public override string ToString()
    {
        return $"Name: {FirstName} {LastName} - ID: {PersonalIdentityNumber}";
    }
}
