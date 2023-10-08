using CompositeDesignPattern;
using CompositeDesignPattern.Components;

var leaf1 = new Leaf();
var leaf2 = new Leaf();
var leaf3 = new Leaf();

var composite1 = new Composite();

composite1.Add(leaf1);
composite1.Add(leaf2);

var composite2 = new Composite();

composite2.Add(leaf3);

var composite = new Composite();

composite.Add(composite1);
composite.Add(composite2);

composite.Operation();

Console.ReadKey();