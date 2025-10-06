namespace WestCoastEducation.Persistent;

public class JsonStorage : IStorage
{
    public string Read(string path)
    {
        return File.ReadAllText(path);
    }

    public void Write(string path, string data)
    {
        File.WriteAllText(path, data);
    }
}
