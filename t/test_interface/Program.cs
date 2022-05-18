using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var airPlane01 = new airPlane();
            var robot01 = new robot();

            var flyingHorse01 = new flyingHorse("flyingHorse01");
            var flyingFish01 = new flyingFish("flyingFish01");
            var seaOtter01 = new seaOtter("seaOtter01");
            var seaBird01 = new seaBird("seaBird01");

            List<Animal> animalList = new List<Animal>();
            List<IFlyable> flyableList = new List<IFlyable>();
            List<IWalkable> walkableList = new List<IWalkable>();
            List<ISwimmable> swimmableList = new List<ISwimmable>();

            Console.WriteLine("----Animal----");
            animalList.Add(flyingHorse01);
            animalList.Add(flyingFish01);
            animalList.Add(seaOtter01);
            animalList.Add(seaBird01);
            foreach(var animal in animalList)
            {
                animal.Breathing();
                //animal.Flying();
                //animal.Walking();
                //animal.Swimming();
            }
            Console.WriteLine("----Flying----");
            flyableList.Add(flyingHorse01);
            flyableList.Add(flyingFish01);
            flyableList.Add(seaBird01);
            flyableList.Add(airPlane01);
            foreach (IFlyable flyable in flyableList)
            {
                //flyable.Breathing();
                flyable.Flying();
                //flyable.Walking();
                //flyable.Swimming();
            }
            Console.WriteLine("----Walking----");
            walkableList.Add(flyingHorse01);
            walkableList.Add(seaOtter01);
            walkableList.Add(seaBird01);
            walkableList.Add(robot01);
            foreach (IWalkable walkable in walkableList)
            {
                //walkable.Breathing();
                //walkable.Flying();
                walkable.Walking();
                //walkable.Swimming();
            }
            Console.WriteLine("----Swimming----");
            swimmableList.Add(flyingFish01);
            swimmableList.Add(seaOtter01);
            swimmableList.Add(seaBird01);
            foreach (ISwimmable swimmable in swimmableList)
            {
                //swimmable.Breathing();
                //swimmable.Flying();
                //swimmable.Walking();
                swimmable.Swimming();
            }

            Console.WriteLine(flyingHorse01.ToString());
            Console.WriteLine(flyingHorse01.MyToString());

        }
    }
    //擴充方法 需 「非泛型 靜態類別的靜態方法」
    static class AnimalExtension
    {
        public static string MyToString(this Animal target)
        {
            return target.Name;
        }
    }
}   