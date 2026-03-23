namespace apbd_cw2_git_s25954;

public class Student : User
{
    public override int maxRentals => 2;

    public Student (string firstName, string lastName) : base(firstName, lastName)
    {
        
    }

    public override string GetUserType()
    {
        return "Student";
    }
}