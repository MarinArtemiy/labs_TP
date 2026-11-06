namespace Game.Objects.Buildings;
using Game.Interfaces;
public class MobileHome : Building, IMoveable
{
    public MobileHome(int id, string name, int x, int y, bool isBuilt = false) : base(id, name, x, y, isBuilt)
    {
    }
    public void Move(int x, int y)
    {
        if (!IsBuilt()) return;
        SetPosition(x, y);
    }
}