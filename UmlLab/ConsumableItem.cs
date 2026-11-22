using System;
public class ConsumableItem : Item
{
    private int healAmount;

    public ConsumableItem(string name, float weight, int healAmount) : base(name, weight)
    {
        this.healAmount = healAmount;
    }

    public override void Use()
    {
        Console.WriteLine($"{name} diminum, memulihkan {healAmount} HP.");
    }
}