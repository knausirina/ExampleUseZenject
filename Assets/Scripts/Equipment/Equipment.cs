using System.Collections.Generic;

public class Equipment : IEquipment
{
    private readonly List<Item> items = new();

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public List<Item> GetItems()
    {
        return items;
    }
}