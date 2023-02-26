using System;

abstract class Prototype
{
    public int Id { get; }

    public Prototype(int id)
    {
        Id = id;
    }

    public abstract Prototype Clone();
}

class PrototypeX : Prototype
{
    public PrototypeX(int id) : base(id)
    {
    }

    public override Prototype Clone()
    {
        return (Prototype)MemberwiseClone();
    }
}

class PrototypeY : Prototype
{
    public PrototypeY(int id) : base(id)
    {
    }

    public override Prototype Clone()
    {
        return (Prototype)MemberwiseClone();
    }
}

class Program
{
    static void Main(string[] args)
    {
        PrototypeX prototypeX1 = new PrototypeX(1);
        PrototypeX prototypeX2 = (PrototypeX)prototypeX1.Clone();

        PrototypeY prototypeY1 = new PrototypeY(2);
        PrototypeY prototypeY2 = (PrototypeY)prototypeY1.Clone();

        Console.WriteLine($"prototypeX1.Id = {prototypeX1.Id}, prototypeX2.Id = {prototypeX2.Id}");
        Console.WriteLine($"prototypeY1.Id = {prototypeY1.Id}, prototypeY2.Id = {prototypeY2.Id}");
    }
}
