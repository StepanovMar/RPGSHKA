using RpgLogicProject;
using System;

var rand = new Random();
Console.WriteLine("Добро пожалавать на Pvp-арену!");
Console.WriteLine("Назови своё имя");
Console.Write("Я:");
string name = Convert.ToString(Console.ReadLine());
var Hero = new Hero(name, 1, 100);
Console.WriteLine("------------------------------------");
var Weapon = new Weapon("Blade of Alcrity", 12);
Console.WriteLine($"То что надо!: {Weapon.Name}");
var Enemy = new Enemy(Arrays.monsters[rand.Next(0, 10)], Hero.Level + rand.Next(0, 1), rand.Next(0, 100), rand.Next(0, 50));
Console.WriteLine($"Противник: {Enemy.Name}");
Console.WriteLine("------------------------------------");
Console.WriteLine("Готов?");
Console.WriteLine("1-Да/2-Нет");
int answer = int.Parse(Console.ReadLine());
Console.WriteLine("------------------------------------");
if (answer == 1)
{

    Console.WriteLine("Начало боя");
    var BattleArena = new BattleArena(Enemy, Hero, Weapon);
    var BackPack = new BackPack(10);
    BackPack.Looting(BattleArena.Battle());
}
else if (answer == 2)
{
    Console.WriteLine("Убегаешь? Ну и п...ока  ");
    Console.WriteLine("Мне нужно зрелище, Поэтому выбирай");
    Console.WriteLine("1-Уйти,2-Дальше биться.Выбирай");
res:
    Console.WriteLine("Я выберу:");
    int answer1 = int.Parse(Console.ReadLine());
    if (answer1 == 1)
    {
        Console.WriteLine($"{Hero.Name}, Я думал, что Ты Сильным духом...");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Конец...");
    }
    if (answer1 == 2)
    {
        Console.WriteLine($"Я сразу заметил, что ты сильный духом! {Hero.Name}");
        Console.WriteLine("Бой начинается!");
        var BattleArena = new BattleArena(Enemy, Hero, Weapon);
        var BackPack = new BackPack(10);
        BackPack.Looting(BattleArena.Battle());

    }
    else
    {
        Console.WriteLine("ТАК НЕЛЬЗЯ!");

    }

}
else
{
    Console.WriteLine("Здесь сюжет!!!");
}
