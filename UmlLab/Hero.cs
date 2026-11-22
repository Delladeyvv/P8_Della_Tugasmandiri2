using System;
public class Hero
{
    private readonly string name;
    private int health;
    private readonly int attackPower;

    public Hero(string name, int health, int attackPower)
    {
        this.name = name;
        this.health = health;
        this.attackPower = attackPower;
    }

    public int Health => health;
    public bool IsAlive => health > 0;

    public void Attack(BossAI boss)
    {
        Console.WriteLine($"{name} menyerang boss.");
        boss.TakeDamage(attackPower);          
    }

    public void TakeDamage(int amount)
    {
        health = Math.Max(0, health - amount);
        Console.WriteLine($"{name} menerima {amount} damage (HP {health}).");
    }
}