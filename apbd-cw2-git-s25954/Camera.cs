namespace apbd_cw2_git_s25954;

public class Camera : Equipment
{
    public string brand { get; set; }
    public int zoom { get; set; }

    public Camera(string brand, int zoom)
    {
        this.brand = brand;
        this.isAvailable = true;
        this.zoom = zoom;
    }
}