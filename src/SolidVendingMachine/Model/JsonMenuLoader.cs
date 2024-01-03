///
/// Single Responsibility Principle
/// A class should have only one reason to change.
/// A class should only do one type of things.
/// 
using System.Text.Json;

public class JsonMenuLoader : IMenuLoader{
    public JsonMenuLoader()
    {
    }

    public List<Product> LoadMenu(string src){
        string text = File.ReadAllText(src);
        return JsonSerializer.Deserialize<List<Product>>(text);
    }
}
