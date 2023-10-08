using CompositeDesignPattern.Components;

namespace CompositeDesignPattern;

public class Composite : Component
{
    private readonly List<Component> _children;

    public Composite()
    {
        _children = new List<Component>();
    }

    public void Add(Component component)
    {
        _children.Add(component);
    }

    public void Remove(Component component)
    {
        _children.Remove(component);
    }

    public override void Operation()
    {
        Console.WriteLine("Composite Operation");
        foreach (var child in _children)
        {
            child.Operation();
        }
    }
}