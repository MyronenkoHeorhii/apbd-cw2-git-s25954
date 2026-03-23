namespace apbd_cw2_git_s25954;

public class User
{
    private static int IdCounter;
    
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Equipment> RentedEquipment { get; set; }
    public virtual int maxRentals { get; set; }

    public User()
    {
        this.Id = IdCounter++;
    }

    public virtual string GetUserType()
    {
        return "User";
    }
}