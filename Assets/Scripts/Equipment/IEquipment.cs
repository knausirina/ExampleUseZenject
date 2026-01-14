using System.Collections.Generic;

public interface IEquipment
{
    void AddItem(Item item);
    List<Item> GetItems();
}