/// 
/// Liskov Substitution Principle (LSP)
/// Objects of a superclass shall be replaceable with objects of its subclasses without breaking the application.
/// A Subclass must be able to fully replace its superclass.
/// 

public static class Extensions
{
    public static PriceTagMaker GetPriceTagMaker(this Product product){
        switch (product.Type)
        {
            case "Drink":
                return new DrinkTypePriceTagMaker();
            case "Fruit":
                return new FruitTypePriceTagMaker();
            default:
                return new PriceTagMaker();
        }
    }
}