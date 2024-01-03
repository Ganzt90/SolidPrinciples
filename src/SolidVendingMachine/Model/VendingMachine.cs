public class VendingMachine : IVendingMachine
{
    private List<Product> _menuLoader;

    public VendingMachine(List<Product> menuLoader){
        this._menuLoader= menuLoader;
    }

    public void SayHello()
    {
        Console.WriteLine("Please enter your name");
        var userName = Console.ReadLine();
        Console.WriteLine($"Hello Dear { userName }! How are you? \n");
    }

    public void TellTime()
    {
        var currentDate = DateTime.Now;
        Console.WriteLine($"Current time is {currentDate:d} at {currentDate:t}! \n");
    }

    public void DisplayMenu()
    {
        // read menu
        var products = _menuLoader;
        //var menuLoader = new JsonMenuLoader();
        //var products = menuLoader.LoadMenu();
        //string text = File.ReadAllText(@"./menu.json");
        //var products = JsonSerializer.Deserialize<List<Product>>(text);

        // show menu
        foreach (var product in products)
        {
            Console.WriteLine(product.ToString());
        }
    }

    public void SayBye()
    {
        Console.Write($"Press any key to exit...");
        Console.ReadKey(true);
    }

    public void Start()
    {
        DisplayMenu();
    }
}