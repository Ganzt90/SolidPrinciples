public class CsvMenuLoader : IMenuLoader
{
    public CsvMenuLoader()
    {
    }
    public List<Product> LoadMenu(string src){
        var list = new List<Product>();
        using (var reader = new StreamReader(src)){
            while (!reader.EndOfStream){
                var line = reader.ReadLine();
                var values = line.Split(',');
                list.Add(new Product { ID = int.Parse(values[0]), Name = values[1], Price = decimal.Parse(values[2]), Type = values[3]});
            }
        }
        return list;
    }
}