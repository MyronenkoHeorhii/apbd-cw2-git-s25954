namespace apbd_cw2_git_s25954;

public class Projector : Equipment
{
    public string projectorType { get; set; }
    public string resolution { get; set; }
    
    public Projector(string name, string description, string projectorType, string resolution) : base(name, description)
    {
        this.projectorType = projectorType;
        this.resolution = resolution;
    }

}