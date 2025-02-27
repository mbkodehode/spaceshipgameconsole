public class SpaceShip
{
    public string Name { get; set; }
    public string Shipclass { get; set; }
    public int Fuelcapacity { get; set; }
    public int CurrentFuel { get; set; }
    public int Speed { get; set; }
    public int FuelUsage { get; set; }
    public int CrewCapasity { get; set; }
    public int Crew { get; set; }
    public string OriginPlanet { get; set; }
    
    public SpaceShip(string Name, string Shipclass, int Fuelcapacity, int Speed, int FuelUsage, int CrewCapasity, int Crew, string OriginPlanet)
    {
        this.Name = Name;
        this.Shipclass = Shipclass;
        this.Fuelcapacity = Fuelcapacity;
        this.Speed = Speed;
        this.FuelUsage = FuelUsage;
        this.CrewCapasity = CrewCapasity;
        this.Crew = Crew;
        this.OriginPlanet = OriginPlanet;
        this.CurrentFuel = Fuelcapacity;
    }
    private Crew _pilot;
    public void
}