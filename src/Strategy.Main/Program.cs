// DO NOT TOUCH THIS
void Iterate(IEnumerable<Warrior> allWarriors)
{
    foreach (var warrior in allWarriors)
    {
        Console.WriteLine($"A warrior {warrior.Name} shows up");
        warrior.Attack();
        Console.WriteLine();
    }
}
// END OF DO NOT TOUCH THIS

var ninja = new Warrior("Ninja", new NunchakuStrike());
var boxer = new Warrior("Boxer", new Punch());
var zombie = new Warrior("Zombie", new Bite());
var karateka = new Warrior("Karateka", new Kick());
var mazingerZ = new Warrior("Mazinger Z", new Punch());

var warriors = new List<Warrior> { ninja, boxer, zombie, karateka, mazingerZ };

Iterate(warriors);

Console.WriteLine("### ZOMBIE APOCALYPSE ###");
ninja.ChangeFight(new Bite());
boxer.ChangeFight(new Bite());
karateka.ChangeFight(new Bite());

Iterate(warriors);

interface IFight
{
    void Fight();
}

class Punch
    : IFight
{
    public void Fight()
    {
        Console.WriteLine("Punch!");
    }
}

class Kick
    : IFight
{
    public void Fight()
    {
        Console.WriteLine("Kick!");
    }
}

class NunchakuStrike
    : IFight
{
    public void Fight()
    {
        Console.WriteLine("Nunchaku strike!");
    }
}

class Bite
    : IFight
{
    public void Fight()
    {
        Console.WriteLine("Bite!");
    }
}


class Warrior
{
    private IFight _fight;
    public string Name { get; }

    public Warrior(string name, IFight fight)
    {
        Name = name;
        _fight = fight;
    }

    public void Attack()
    {
        _fight.Fight();
    }

    public void ChangeFight(IFight fight)
    {
        _fight = fight;
    }
}