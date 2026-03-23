namespace apbd_cw2_git_s25954;

public class Employee : User
{
    public override int maxRentals => 5;

    public override string GetUserType()
    {
        return "Employee";
    }
}