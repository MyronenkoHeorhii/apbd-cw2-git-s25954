namespace apbd_cw2_git_s25954;

public class Projector : Equipment
{
    public string projectorType { get; set; }
    public string resolution { get; set; }
    
    public Projector(string projectorType, string resolution)
    {
        this.projectorType = projectorType;
        this.isAvailable = true;
        this.resolution = resolution;
    }

}