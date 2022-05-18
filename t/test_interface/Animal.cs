using System;
namespace test_interface
{
	public class Animal
	{
		
		public string Name { get; set; }
		public Animal(string name)
		{
			Name = name;
		}
		public void Breathing()
		{
            Console.WriteLine($"{Name} is {nameof(Breathing)}");
		}
	}
    class flyingHorse : Animal, IFlyable, IWalkable
    {
        public flyingHorse(string name) : base(name)
        {
        }
        public void Flying()
        {
            Console.WriteLine($"{nameof(flyingHorse)} is {nameof(Flying)}.");
        }
        public void Walking()
        {
            Console.WriteLine($"{nameof(flyingHorse)} is {nameof(Walking)}.");
        }
    }
    class seaBird : Animal, IFlyable, IWalkable, ISwimmable
    {
        public seaBird(string name) : base(name)
        {
        }
        public void Flying()
        {
            Console.WriteLine($"{nameof(seaBird)} is {nameof(Flying)}.");
        }
        public void Swimming()
        {
            Console.WriteLine($"{nameof(seaBird)} is {nameof(Swimming)}.");
        }
        public void Walking()
        {
            Console.WriteLine($"{nameof(seaBird)} is {nameof(Walking)}.");
        }
    }
    class seaOtter : Animal, IWalkable, ISwimmable
    {
        public seaOtter(string name) : base(name)
        {
        }
        public void Walking()
        {
            Console.WriteLine($"{nameof(seaOtter)} is {nameof(Walking)}.");
        }
        public void Swimming()
        {
            Console.WriteLine($"{nameof(seaOtter)} is {nameof(Swimming)}.");
        }
    }
    class flyingFish : Animal, IFlyable, ISwimmable
    {
        public flyingFish(string name) : base(name)
        {
        }
        public void Flying()
        {
            Console.WriteLine($"{nameof(flyingFish)} is {nameof(Flying)}.");
        }
        public void Swimming()
        {
            Console.WriteLine($"{nameof(flyingFish)} is {nameof(Swimming)}.");
        }
    }
    class airPlane : IFlyable
    {
        public void Flying()
        {
            Console.WriteLine($"{nameof(airPlane)} is {nameof(Flying)}.");
        }
    }
    class robot : IWalkable
    {
        public void Walking()
        {
            Console.WriteLine($"{nameof(robot)} is {nameof(Walking)}.");
        }
    }
}

