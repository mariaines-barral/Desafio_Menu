using System.Security.Cryptography;

namespace Ucu.Poo.Restaurant;

/// Pescado
/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    private string name;
    public string Name
    {
        get { return name; } set { name = value; }
    }
    private double price;
    public double Price
    {
        get { return price; } set { price = value; }
    }
    private bool isVegetarian;
    public bool IsVegetarian
    {
        get { return isVegetarian; } set { isVegetarian = value; }
    }

    public Dish(string name, double price, bool isVegetarian)
    {
        {
            this.Name = name;
            this.Price = price;
            this.IsVegetarian = isVegetarian;
        }
    }
}