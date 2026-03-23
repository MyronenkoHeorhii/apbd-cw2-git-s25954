namespace apbd_cw2_git_s25954;

public class RentalService
{
    public void CreateRental(User user, Equipment equipment, int days)
    {

        if (!equipment.isAvailable)
        {
            throw new Exception("Equipment is not available");
        }

        if (user.RentedEquipment.Count >= user.maxRentals)
        {
            throw new Exception("You cannot have more than " + user.maxRentals + " rentals");
        }

        DateOnly now = DateOnly.FromDateTime(DateTime.Now);
        DateOnly dueDate = now.AddDays(days);
        
        Rental newRental = new Rental(now, dueDate);
        
        newRental.Renter = user;
        newRental.RentedEquipment = equipment;

        equipment.isAvailable = false;
        user.RentedEquipment.Add(equipment);
    }
}