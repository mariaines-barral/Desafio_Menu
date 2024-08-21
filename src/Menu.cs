namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>
public class Menu
{
    private ArrayList dishes = new ArrayList();

    public void AddDish(Dish)
    {
        dishes.Add(Dish);
    }

    public void RemoveDish(Dish)
    {
        dishes.Remove(Dish)
    }

    public Dish GetDishByName(string dishName)
    {
        foreach (var dish in dishes)
        {
            if (dish.Name == dishName)
            {
                return dish
            }
            else return null
        }
    }
}

