/// 
/// Interface Segregation Principle (ISP)
/// No client should be forced to depend on methods it does not use.
/// Use small, concise interfaces.
/// 

public class HighEfficiencyVendingMachine : IVendingMachine
{
    private List<Product> _menuLoader;

    public HighEfficiencyVendingMachine(List<Product> menuLoader)
    {
        this._menuLoader = menuLoader;
    }

    public void DisplayMenu()
    {
        //Read Menu
        var products = _menuLoader;
        //Show Menu
        foreach (var product in products)
        {
            Console.WriteLine(product.ToString());
        }
    }

    public void Start()
    {
        DisplayMenu();
    }
}