namespace Game.Objects;
public class Building : GameObject
{
    private bool _isBuilt;
    public Building(int id, string name, int x, int y, bool isBuilt = false) : base(id, name, x, y)
    {
        _isBuilt = isBuilt;
    }

    public bool IsBuilt() => _isBuilt;

    public void Build()
    {
        _isBuilt = true;
    }
}
