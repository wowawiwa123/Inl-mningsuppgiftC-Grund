namespace WestCoastEducation.Application;
using System.Text.Encodings.Web;
using System.Text.Json;
using WestCoastEducation.Domain;
using WestCoastEducation.Persistent;

public class JsonService : ICourseService
{
    private readonly IStorage _storage;

    public JsonService(IStorage storage)
    {
        _storage = storage;
    }
    private static JsonSerializerOptions _options = new()
    {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true
    };
    public void SaveCourse(string path, Course course)
    {
        string json = JsonSerializer.Serialize(course, _options);
        _storage.Write(path, json);
    }

    public Course GetCourse(string path)
    {
        _options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var json = _storage.Read(path);
        Console.WriteLine(json);

        var course = JsonSerializer.Deserialize<Course>(json, _options);

        return course ?? new Course();
    }
}
