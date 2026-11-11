using Game.Objects;
//var testUnit = new Unit(-1,"",1,0, -2);
var arch1 = new Archer(id: 1, name: "arch1", x: 0, y: 0, hp: 100f, damage: 25f);
var arch2 = new Archer(id: 2, name: "arch2", x: 8, y: 8, hp: 30f, damage: 10f);
var fort = new Fort(id: 3, name: "keep", x: 10, y: 10, damage: 40f);
var wagon = new MobileHome(id: 4, name: "wagon", x: 2, y: 2);

Console.WriteLine("Archer moves");
PrintObject(arch1);
arch1.Move(3, 4); //archer move test
PrintObject(arch1);

Console.WriteLine("Archer1 attacks and kills Archer2");
PrintUnit(arch2);
while (arch2.IsAlive())
{
    arch1.Attack(arch2); //arch1 attack test
    PrintUnit(arch2); //arch1 kills arch2
}

Console.WriteLine("We try to move Archer2");
Console.WriteLine($"{arch2.GetName()} (dead) tries to move to (0, 0)");
arch2.Move(0, 0); //(dead) arch2 tries to move
PrintUnit(arch2);

Console.WriteLine("We try to force Archer2 to attack Archer1");
PrintUnit(arch1);
Console.WriteLine($"{arch2.GetName()} (dead) tries to attack {arch1.GetName()}");
arch2.Attack(arch1); //(dead) arch2 tries to attack arch1
PrintUnit(arch1);

Console.WriteLine("Fort attacks only after it is built");
Console.WriteLine($"{fort.GetName()} built: {fort.IsBuilt()}"); //Fort attacks only after it is built
fort.Attack(arch1); //unbuilt fort fails
Console.WriteLine("Unbuilt fort tries to fire at arch1");
PrintUnit(arch1);
fort.Build();
Console.WriteLine($"{fort.GetName()} built: {fort.IsBuilt()}");
fort.Attack(arch1); //built fort succeeds
Console.WriteLine("Built fort fires at arch1");
PrintUnit(arch1);

Console.WriteLine("Mobile home moves only after it is built");
Console.WriteLine($"{wagon.GetName()} built: {wagon.IsBuilt()}");
PrintObject(wagon);
wagon.Move(7, 3);
Console.WriteLine("Unbuilt wagon tries to move to (7, 3):");
PrintObject(wagon);
wagon.Build();
wagon.Move(7, 3);
Console.WriteLine("Built wagon moves to (7, 3):");
PrintObject(wagon);

//Print functions
static void PrintObject(GameObject obj)
{
    Console.WriteLine($"    [{obj.GetId()}] {obj.GetName()} at ({obj.GetX()}, {obj.GetY()})");
}

static void PrintUnit(Unit unit)
{
    Console.WriteLine(
        $"    [{unit.GetId()}] {unit.GetName()} at ({unit.GetX()}, {unit.GetY()}), " +
        $"HP: {unit.GetHp()}, alive: {unit.IsAlive()}");
}