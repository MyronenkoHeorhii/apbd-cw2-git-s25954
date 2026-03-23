namespace apbd_cw2_git_s25954;

public class Rental
{
    private static int _Penalty = 100;
    
    public static int Penalty{get{return _Penalty;} set{_Penalty = value;}}
    
    public DateOnly RentalDate { get; set; }
    public DateOnly DueDate { get; set; }
    public DateOnly ReturnDate { get; set; }
    public int Fee{get;set;}

    public User Renter { get; set; }
    public Equipment RentedEquipment { get; set; }

    public Rental(DateOnly rentalDate, DateOnly dueDate)
    {
        this.RentalDate = rentalDate;
        this.DueDate = dueDate;
    }
    
}