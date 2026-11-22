using System;
public class WeaponItem : Item
{
    private int damage;

    public WeaponItem(string name, float weight, int damage) : base(name, weight)
    {
        this.damage = damage;
    }

    public override void Use()
    {
        Console.WriteLine($"{name} dipakai menyerang dengan damage {damage}.");
    }
}