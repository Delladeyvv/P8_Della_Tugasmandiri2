using System;
public class Inventory
{
    private readonly List<Item> items = new();
    private readonly int capacity;

    public Inventory(int capacity)
    {
        this.capacity = capacity;
    }

    public bool AddItem(Item item)
    {
        if (items.Count >= capacity)
        {
            Console.WriteLine($"Inventory penuh, {item.GetName()} ditolak.");
            return false;
        }
        items.Add(item);
        Console.WriteLine($"{item.GetName()} ditambahkan ({items.Count}/{capacity}).");
        return true;
    }

    public bool RemoveItem(Item item) => items.Remove(item);

    public float GetTotalWeight() => items.Sum(i => i.GetWeight());

    public void ShowAll()
    {
        Console.WriteLine($"Isi inventory ({items.Count}/{capacity}):");
        foreach (var item in items)
            Console.WriteLine($" - {item.GetName()} ({item.GetWeight()} kg)");
    }

    public void UseAll()
    {
        foreach (var item in items)
            item.Use();
    }
}