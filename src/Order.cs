namespace Ucu.Poo.Restaurant;
using System.Collections;

public class Order
{
    private ArrayList dishes = new ArrayList();
    
    public ArrayList Dishes
    {
        get{ return dishes; }
    }
    public double GetTotal()
    {
        double total = 0;
        for (int i = 0; i < this.dishes.Count; i++)
        {
            total += ((Dish)this.dishes[i]).Price;
        }
        return total;
    }
}