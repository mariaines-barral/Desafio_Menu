namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private Order order;
    private bool isOccupied;
    private int number;
    
    public bool IsOccupied
    {
        get { return this.isOccupied; }
        set { this.isOccupied = value; }
    }

    public int Number
    {
        get { return this.number; }
        set { this.number = value; }
    }
    public Table(int number)
    {
        this.number = number;
    }
    
    public bool HasOrders()
    {
        return this.order.Dishes.Count > 0;
    }
    
    public void Ocupy()
    {
        this.isOccupied = true;
    }

    public void AddToOrder(Dish dish)
    {
        this.order.Dishes.Add(dish);
    }

    public void Free()
    {
        this.isOccupied = false;
        this.order.Dishes.Clear();
        
    }
}