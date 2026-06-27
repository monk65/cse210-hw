class Animal
{
    protected string _name;

    public Animal(string name)
    {
        _name = name;
    }

    public virtual void MakeNoise()
    {
        Console.WriteLine($"{_name} says what everything else says");
    }
}