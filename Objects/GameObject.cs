namespace Game.Objects;
public abstract class GameObject
{
    private readonly int _id;
    private readonly string _name;
    private int _x;
    private int _y;

    protected GameObject(int id, string name, int x, int y)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name must not be empty", nameof(name));
            
        _id = id;
        _name = name;
        _x = x;
        _y = y;
    }
    public int GetId() => _id;
    public string GetName() => _name;
    public int GetX() => _x;
    public int GetY() => _y;

    protected void SetPosition(int x, int y)
    {
        _x = x;
        _y = y;
    }
}