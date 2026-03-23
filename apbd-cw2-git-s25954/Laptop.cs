namespace apbd_cw2_git_s25954;

public class Laptop : Equipment
{

    public string operatingSystem { get; set; }
    public int ram { get; set; }


    public Laptop(string name, string description, string operatingSystem, int ram) : base(name, description)
    {
        this.operatingSystem = operatingSystem;
        this.ram = ram;
    }
}