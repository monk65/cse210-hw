
public class Program
{
    public static void Main()
    {
        List<Animal> myAnimals = new List <Animal> ();


        myAnimals.Add(new Animal("Liger"));
        myAnimals.Add(new Dog("hit"));
        myAnimals.Add(new Cat("doug"));
        foreach (Animal critter in myAnimals)
        {
            critter.MakeNoise();
        }
    }
}
