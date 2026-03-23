namespace apbd_cw2_git_s25954;

public class Rental
{
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