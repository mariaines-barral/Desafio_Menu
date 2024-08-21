using System.Collections;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    public string Name;

    public string name
    {
        get { return name; } set { name = value; }
    }
    
    private ArrayList assignedTables = new ArrayList();

    public void AssignTable(Table table)
    {
        assignedTables.Add(table);
    }
    
    public void TakeOrder(Table table, Dish dish)
    {
        if (assignedTables.Contains(table))
        { 
            table.AddToOrder(dish);
        }
    }
    
    public Waiter(string name)
    {
        {
            this.Name = name;
        }
    }
    
}