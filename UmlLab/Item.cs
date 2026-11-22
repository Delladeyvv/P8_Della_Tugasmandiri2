using System;
public abstract class Item
{
    protected string name;
    protected float weight;

    protected Item(string name, float weight)
    {
        this.name = name;
        this.weight = weight;
    }

    public string GetName() => name;
    public float GetWeight() => weight;

    public abstract void Use();
}