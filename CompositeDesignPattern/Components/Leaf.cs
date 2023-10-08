namespace CompositeDesignPattern.Components;

public class Leaf : Component
{
    public override void Operation()
    {
        Console.WriteLine("Leaf Operation");
    }
}