using System;
namespace spaceshipgame
{
    public class Program
    {
        public static void Main(string[] args)
        {

            while (Menu.showmenue)
            {
                Menu.showmenue = Menu.StartMenu();
            }
        
            Console.WriteLine("Hello World");

            SpaceShip starterShip = new SpaceShip("Nebuchadnezzar", "Hauler", 10000, 100, 10, 10, 1, "Earth");
            Crew startercrew = new Crew();
        }
    }
}