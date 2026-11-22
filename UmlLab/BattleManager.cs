using System;
public static class BattleManager
{
    // Satu putaran serangan = isi sequence diagram Tugas 4.
    public static void RunRound(int round, Hero hero, BossAI boss)
    {
        Console.WriteLine($"--- Ronde {round} ---");
        hero.Attack(boss);                                 
        if (boss.Phase == BossPhase.Defeated) return;       
        boss.Act(hero);                                     
    }

    public static void RunBattle(Hero hero, BossAI boss)
    {
        int round = 1;
        while (hero.IsAlive && boss.Phase != BossPhase.Defeated)
        {
            RunRound(round++, hero, boss);
        }

        Console.WriteLine(boss.Phase == BossPhase.Defeated
            ? $"Boss dikalahkan! Sisa HP hero: {hero.Health}"
            : "Hero gugur. Boss menang.");
    }
}