class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} says meow");
    }
}