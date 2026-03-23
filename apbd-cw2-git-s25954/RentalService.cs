namespace apbd_cw2_git_s25954;

public class RentalService
{
    public static List<Rental> Rentals { get; set; } = new List<Rental>();
    
    public static void CreateRental(User user, Equipment equipment, int days)
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

    public static void ReturnRental(User user, Equipment equipment)
    {
        Rental rental = null;

        foreach (Rental r in Rentals)
        {
            if (r.Renter == user && r.RentedEquipment == equipment)
            {
                rental = r;
            }
        }

        if (rental == null)
        {
            throw new Exception("Rental not found");
        }

        DateOnly now = DateOnly.FromDateTime(DateTime.Now);
        
        rental.ReturnDate = now;

        if (rental.DueDate < rental.ReturnDate)
        {
            int difference = rental.ReturnDate.DayNumber - rental.DueDate.DayNumber;
            
            rental.Fee = Rental.Penalty * difference;
            
            Console.WriteLine("Late Rental return. Adding fee of " + rental.Fee);
        }
        
        rental.Renter.RentedEquipment.Remove(rental.RentedEquipment);
        rental.RentedEquipment.isAvailable = true;
    }

    public static void ActiveRentalsByUser(User user)
    {
        foreach (Equipment equipment in user.RentedEquipment)
        {
            Console.WriteLine(equipment.name + "; " + equipment.description);
        }
    }

    public static void ShowOverdueRentals()
    {
        foreach (Rental rental in Rentals)
        {
            if (rental.ReturnDate.DayNumber > rental.DueDate.DayNumber)
            {
                Console.WriteLine(rental.RentedEquipment.name + "; " + rental.Renter.FirstName + " " + rental.Renter.LastName + "; " + rental.RentalDate + "; " + rental.ReturnDate + ";");
            }
        }
    }
}