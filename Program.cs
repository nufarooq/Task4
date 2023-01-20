namespace AbstractClassTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("Enter Dog Name");
            dog.SetName(Console.ReadLine());
            Console.WriteLine("Dog Name is " + dog.GetName());
            dog.Eat();
        }
    }

    public abstract class Animal
    {
        private string Name;

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public abstract void Eat();
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is Eating");
        }
    }

}