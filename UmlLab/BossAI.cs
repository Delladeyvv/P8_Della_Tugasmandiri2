using System;
public enum BossPhase { Phase1, Phase2, Enraged, Defeated }

public class BossAI
{
    private const int MaxHealth = 1000;
    private int health = MaxHealth;
    private BossPhase phase = BossPhase.Phase1;

    public int Health => health;
    public BossPhase Phase => phase;

    public void TakeDamage(int damage)
    {
        if (phase == BossPhase.Defeated) return;

        health = Math.Max(0, health - damage);
        Console.WriteLine($"Boss menerima {damage} damage (HP {health}/{MaxHealth}).");
        EvaluatePhase();                        
    }

    private void EvaluatePhase()
    {
        while (TryChangePhase()) { }
    }

    private bool TryChangePhase()
    {
        double ratio = (double)health / MaxHealth;
        BossPhase next = phase;

        if (health <= 0) next = BossPhase.Defeated;
        else if (phase == BossPhase.Phase1 && ratio <= 0.60) next = BossPhase.Phase2;
        else if (phase == BossPhase.Phase2 && ratio <= 0.25) next = BossPhase.Enraged;

        if (next == phase) return false;

        Console.WriteLine($"** Boss berubah fase: {phase} -> {next}");
        phase = next;
        return true;
    }

    public void Act(Hero target)               
    {
        int damage = phase switch
        {
            BossPhase.Phase1 => 20,
            BossPhase.Phase2 => 35,
            BossPhase.Enraged => 60,
            _ => 0
        };
        if (damage == 0) return;

        Console.WriteLine($"Boss ({phase}) menyerang hero.");
        target.TakeDamage(damage);              
    }
}
