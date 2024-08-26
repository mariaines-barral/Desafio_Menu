namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    private string name;
    private double price;
    private bool isVegetarian;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public double Price
    {
        get { return this.price; }
        set { this.price = value; }
    }

    public bool IsVegetarian
    {
        get { return this.isVegetarian; }
        set { this.isVegetarian = value; }
    }

    public Dish(string name, double price, bool isVegetarian)
    {
        this.name = name;
        this.price = price;
        this.isVegetarian = isVegetarian;
    }
}