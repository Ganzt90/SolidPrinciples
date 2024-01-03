/// 
/// Open Closed Principle
/// Software entities such as classes, modules, functions, should be open for extension, but closed for modification.
/// When making changes, try to not modify the old working code, add new code instead
/// 
public class PriceTagMaker
{
    public virtual string MakePriceTagForProduct(Product product){
        return $"{product.Price:0.##}";
    }
}

public class DrinkTypePriceTagMaker : PriceTagMaker
{
    public override string MakePriceTagForProduct(Product product)
    {
        var baseprice = base.MakePriceTagForProduct(product);
        return $"{baseprice} + ${product.Price * 0.1m: 0.##} Deposit Fee";
    }
}

public class FruitTypePriceTagMaker : PriceTagMaker
{
    public override string MakePriceTagForProduct(Product product)
    {
        var baseprice = base.MakePriceTagForProduct(product);
        return $"{baseprice} + ${product.Price * 0.05m: 0.##} wrapping Fee";
    }
}