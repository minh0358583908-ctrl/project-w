using System;
using static Chicken;

class AbstractAndInterfaceTests
{
    static void Main(string[] args)
    {
        
        Animal[] animals = new Animal[2];
        animals[0] = new Tiger();
        animals[1] = new Chicken();

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.MakeSound());

            if (animal is Chicken)
            {
                Edible edible = (Chicken)animal;
                Console.WriteLine(edible.HowToEat());
            }
        }

        Console.WriteLine("------ Fruit ------");

        Fruit[] fruits = new Fruit[2];
        fruits[0] = new Orange();
        fruits[1] = new Apple();

        foreach (Fruit fruit in fruits)
        {
            Console.WriteLine(fruit.HowToEat());
        }
    }
}

public interface Edible
    {
        String HowToEat();
    }
     
    public abstract class Animal
    {
        public abstract string MakeSound();
    }
    public class Tiger : Animal
    {
        public override string MakeSound()
        {
            return "Ho: gam ren ri!";
        }
    }
    public class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "Ga: cuc cuc cuc!";
        }

        public string HowToEat()
        {
            return "Ga co the chien đuoc";
        }
        public abstract class Fruit : Edible
        {
            public abstract string HowToEat();
        }
        public class Apple : Fruit
        {
            public override string HowToEat()
            {
                return "Apple co the got vo đe an";
            }
        }
        public class Orange : Fruit
        {
            public override string HowToEat()
            {
                return "Co the vat lay nuoc cam";
            }
        }



    }
























