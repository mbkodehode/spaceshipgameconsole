public class Planet
{
    public string Name { get; set; }
    public int Class { get; set; }
    public string Type { get; set; }
    public int Population { get; set; }
    public int Gravity { get; set; }
    public bool isHabitable { get; set; }
    public bool isHabiteted { get; set; }
    public int Location { get; set; }

    public  Planet (string Name, int Class, string Type, int Population, int Gravity, bool isHabitable, bool isHabiteted, int Location)
    {
        this.Name = Name;
        this.Class = Class;
        this.Type = Type;
        this.Population = Population;
        this.Gravity = Gravity;
        this.isHabitable = isHabitable;
        this.isHabiteted = isHabiteted;
        this.Location = Location;
    }
}