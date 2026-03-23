namespace apbd_cw2_git_s25954;

public class RentalService
{
    public List<Rental> Rentals {get;set;}
    
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
        
        Rentals.Add(newRental);
    }

    public void ReturnRental(Rental rental)
    {
        DateOnly now = DateOnly.FromDateTime(DateTime.Now);
        
        rental.ReturnDate = now;

        if (rental.DueDate < rental.ReturnDate)
        {
            Console.WriteLine("Late Rental return. Adding fee");
            
            int difference = now.DayNumber - rental.ReturnDate.DayNumber;
            
            rental.Fee = 100 * difference;
        }
        
        rental.Renter.RentedEquipment.Remove(rental.RentedEquipment);
        rental.RentedEquipment.isAvailable = true;
    }

    public void ActiveRentalsByUser(User user)
    {
        foreach (Equipment equipment in user.RentedEquipment)
        {
            Console.WriteLine(equipment.name + "; " + equipment.description);
        }
    }

    public void ShowOverdueRentals()
    {
        foreach (Rental rental in Rentals)
        {
            if (rental.ReturnDate > rental.DueDate)
            {
                Console.WriteLine(rental.RentedEquipment.name + "; " + rental.Renter + "; " + rental.RentalDate + "; " + rental.ReturnDate + ";");
            }
        }
    }
}