public class Planet
{
    public string Name { get; set; }
    public int Class { get; set; }
    public string Type { get; set; }
    public double Population { get; set; }
    public double Gravity { get; set; }
    public bool isHabitable { get; set; }
    public bool isHabiteted { get; set; }
    public int Location { get; set; }

    // public  Planet (string Name, int Class, string Type, double Population, double Gravity, bool isHabitable, bool isHabiteted, int Location)
    // {
    //     // Constructor
    //     this.Name = Name;
    //     this.Class = Class;
    //     this.Type = Type;
    //     this.Population = Population;
    //     this.Gravity = Gravity;
    //     this.isHabitable = isHabitable;
    //     this.isHabiteted = isHabiteted;
    //     this.Location = Location;
    // }

    public static 
public static List<Planet> GetAvailablePlanets()
{
    return new List<Planet>
    {
        new Planet("Earth", 1, "Terrestrial", 7800000000, 9.8, true, true, 0),
        new Planet("Mars", 2, "Terrestrial", 700000, 3.7, true, true, 10),
        new Planet("Venus", 3, "Terrestrial", 0, 8.87, false, false, 13),
        new Planet("Jupiter", 4, "Gas Giant", 0, 24.79, false, false, 33)
    };
}
}


