namespace Game.Objects.Units;
using Game.Interfaces;
public class Archer : Unit, IAttacker, IMoveable
{
    private float _damage;
    public Archer(int id, string name, int x, int y, float hp, float damage) : base(id, name, x, y, hp)
    {
        if (damage < 0)
            throw new ArgumentOutOfRangeException(nameof(damage), "Damage value must not be negative");
 
        _damage = damage;
    }
    public void Attack(Unit unit)
    {
        if (unit is null)
            throw new ArgumentNullException(nameof(unit));
        if (!IsAlive()) return;
        unit.ReceiveDamage(_damage);
    }
    public void Move(int x, int y)
    {
        if (!IsAlive()) return;

        SetPosition(x, y);
    }
}