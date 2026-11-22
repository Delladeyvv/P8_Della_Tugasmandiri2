using System;

var hero = new Hero("Aldric", 300, 130);
var boss = new BossAI();
BattleManager.RunBattle(hero, boss);
