namespace spaceshipgame
{
    public static class Menu
    {
        public static SpaceShip? CurrentShip { get; set; }
        public static bool showGameMenu = false;
        public static bool showmenue = true;
        
        public static bool StartMenu()
        {
            Console.Clear();
            System.Console.WriteLine("welcome to the start of this adventure");
            System.Console.WriteLine("please chose one of the following options");
            System.Console.WriteLine("1. start the game");
            System.Console.WriteLine("2. exit the game");
            
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    GameMenu();
                    showGameMenu = true;
                    return true;
                case ConsoleKey.D2:
                    exitgame(); 
                    return false;
                default:
                    
                    return true;

            }
        }

        public static void GameMenu()
        {
            Console.Clear();
            System.Console.WriteLine("welcome to the start of this adventure");
            System.Console.WriteLine("please chose one of the following options");
            System.Console.WriteLine("1. Build Spaceship");
            System.Console.WriteLine("2. Set Destination Planet");
            System.Console.WriteLine("3. Show Fuel Gauge");
            System.Console.WriteLine("4. Refuel Spaceship");
            System.Console.WriteLine("5. Assign Pilot");
            System.Console.WriteLine("6. Show Hangar Status");
            System.Console.WriteLine("7. Show Cockpit Indicators");
            System.Console.WriteLine("8. Shut Down Control System (Exit Program)");
            
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    buildSpaceship();
                    break;
                case ConsoleKey.D2:
                    setDestinationPlanet();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    if (CurrentShip != null)
                    {
                    ShowFuelGauge(CurrentShip);
                    }
                    else 
                    {
                        System.Console.WriteLine("you do not have a ship yet");
                    }
                    break;
                case ConsoleKey.D4:
                    refuelSpaceship();
                    break;
                case ConsoleKey.D5:
                    assignPilot();
                    break;
                case ConsoleKey.D6:
                    showHangarStatus();
                    break;
                case ConsoleKey.D7:
                    showCockpitIndicators();
                    break;
                case ConsoleKey.D8:
                    shutDownControlSystem();
                    break;
                    
                default:
                    GameMenu();
                    break;
            }
                    
        }


        public static void exitgame()
        {
            Console.Clear();
            System.Console.WriteLine("goodbye");
            System.Environment.Exit(0);
        }

        public static void buildSpaceship()
        {
            Console.Clear();
            System.Console.WriteLine("Lets build your new spaceship");
            System.Console.WriteLine("Please enter the name of your new spaceship");
            string? name = Console.ReadLine();
            System.Console.WriteLine("Please enter the ship class of your new spaceship");
            string? shipclass = Console.ReadLine();
            System.Console.WriteLine("Please enter the fuel capacity of your new spaceship");
            int? fuelcapacity = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Please enter the speed of your new spaceship");
            int? speed = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Please enter the fuel usage of your new spaceship");
            int? fuelusage = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Please enter the crew capacity of your new spaceship");
            int? crewcapasity = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Please enter number of crew of your new spaceship");
            int crew = Convert.ToInt32(Console.ReadLine());
            Crew crew1 = new Crew();
            SpaceShip spaceship = new SpaceShip(name, shipclass, (int)fuelcapacity, (int)speed, (int)fuelusage, (int)crewcapasity, crew, "Earth", crew1);
            System.Console.WriteLine($"Your new spaceship is now called {spaceship.Name} and has a crew capacity of {spaceship.CrewCapasity} and a crew of {spaceship.Crew} people.");
        }
        public static void setDestinationPlanet()
        {
                Console.Clear();
                System.Console.WriteLine("Please enter the name of the planet you want to travel to");
                List<Planet> availablePlanets = Planet.GetAvailablePlanets();
                foreach (Planet p in availablePlanets)
                {
                    System.Console.WriteLine($"{p.Name}");
                }
                
                string destinationPlanet = Console.ReadLine();
                Console.WriteLine("Calculating fuel cost...");
                
                // Assume distance is a known value for the sake of this example
                int distanceToPlanet = 500; // Example distance in some unit
                int fuelUsagePerUnit = 10; // Example fuel usage per unit distance
                
                int CalculateFuelCost(int distance, int fuelUsage)
                {
                    return distance * fuelUsage;
                }

                int fuelCost = CalculateFuelCost(distanceToPlanet, fuelUsagePerUnit);
                Console.WriteLine($"The fuel cost for traveling to the planet is: {fuelCost}");

                if (CurrentShip.CurrentFuel >= fuelCost)
                {
                    System.Console.WriteLine("ship has insufficient fuel for this trip, please refuel first");
                    
                }
                else
                {
                    CurrentShip.CurrentFuel -= fuelCost;
                    CurrentShip.OriginPlanet = destinationPlanet;
                    System.Console.WriteLine($"You have successfully traveled to the planet {destinationPlanet}");
                }
        }
        private static void ShowFuelGauge(SpaceShip currentShip)
        {
            System.Console.WriteLine($"you current have {currentShip.CurrentFuel} KG of Dark Matter left");;
        }
        private static void refuelSpaceship()
        {
            throw new NotImplementedException();
        }
       
        private static void showCockpitIndicators()
        {
            throw new NotImplementedException();
        }

        private static void showHangarStatus()
        {
            throw new NotImplementedException();
        }

        private static void assignPilot()
        {
            throw new NotImplementedException();
        }
        private static void shutDownControlSystem()
        {
            throw new NotImplementedException();
        }

    }
}