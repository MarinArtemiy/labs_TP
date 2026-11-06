namespace Game.Objects.Units;
public class Unit : GameObject
{
    private float _hp;
        public Unit(int id, string name, int x, int y, float hp) : base(id, name, x, y)
    {
        if (hp < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(hp), "Damage value must not be negative");
        }
        _hp = hp;
    }
    public bool IsAlive() => _hp > 0;
    public float GetHp() => _hp;

    public void ReceiveDamage(float damage)
    {
        if (damage < 0)
            throw new ArgumentOutOfRangeException(nameof(damage), "Damage value must not be negative");
        _hp = Math.Max(0, _hp - damage);
    }
}
