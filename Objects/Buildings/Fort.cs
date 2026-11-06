namespace Game.Objects.Buildings;
using Game.Interfaces;
using Game.Objects.Units;

public class Fort : Building, IAttacker
{
    private float _damage;
    public Fort(int id, string name, int x, int y, float damage, bool isBuilt = false) : base(id, name, x, y, isBuilt)
    {
        if (damage < 0)
            throw new ArgumentOutOfRangeException(nameof(damage), "Damage value must not be negative");
 
        _damage = damage;
    }
    public void Attack(Unit unit)
    {
        if (unit is null)
            throw new ArgumentNullException(nameof(unit));
        if (!IsBuilt()) return;
        unit.ReceiveDamage(_damage);
    }
}
