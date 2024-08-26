namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private ArrayList order = new ArrayList();
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
        return this.order.Count > 0;
    }
    
    public void Ocupy()
    {
        this.isOccupied = true;
    }

    public void AddToOrder(Dish dish)
    {
        this.order.Add(dish);
    }

    public void Free()
    {
        this.isOccupied = false;
        this.order.Clear();
        
    }
}