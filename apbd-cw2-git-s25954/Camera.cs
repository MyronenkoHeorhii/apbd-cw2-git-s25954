namespace apbd_cw2_git_s25954;

public class Camera
{
    public string brand { get; set; }
    public int zoom { get; set; }

    public Camera(string brand, int zoom)
    {
        this.brand = brand;
        this.zoom = zoom;
    }
}