namespace apbd_cw2_git_s25954;

public class Laptop : Equipment
{

    public string operatingSystem { get; set; }
    public int ram { get; set; }


    public Laptop(string name, string description)
    {
        this.name = name;
        this.isAvailable = true;
        this.description = description;
        
    }
}