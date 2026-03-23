namespace apbd_cw2_git_s25954;

public class Equipment
{
    private static int idCount;
    
    public int id {get;set;}
    public string name {get;set;}
    public bool isAvailable {get;set;}
    public string description {get;set;}

    protected Equipment(string name, string description)
    {
        this.id = idCount++;
        this.name = name;
        this.description = description;
        this.isAvailable = true;
    }
}