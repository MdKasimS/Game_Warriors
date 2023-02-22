int heroHealth, monsterHealth;

heroHealth = 10;
monsterHealth = 10;

int attack;

Random randomAttack = new System.Random();



while(heroHealth>0 && monsterHealth>0)
{
    attack = randomAttack.Next(1,11);
    monsterHealth-=attack;
    Console.WriteLine($"Monster was damaged and lost {attack} and has now {monsterHealth} health");

    if(monsterHealth>0){
        attack = randomAttack.Next(1,11);
        heroHealth-=attack;
        Console.WriteLine($"Hero was damaged and lost {attack} and has {heroHealth}");
    }
}

if(heroHealth>0)
    Console.WriteLine("Hero wins!");
else
    Console.WriteLine("Monster wins!");