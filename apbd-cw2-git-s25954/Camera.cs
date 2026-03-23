namespace apbd_cw2_git_s25954;

public class Camera : Equipment
{
    public string brand { get; set; }
    public int zoom { get; set; }

    public Camera(string name, string description, string brand, int zoom) : base(name, description)
    {
        this.brand = brand;
        this.zoom = zoom;
    }
}