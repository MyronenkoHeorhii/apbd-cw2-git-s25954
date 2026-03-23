using apbd_cw2_git_s25954;

public class Program
{
	public static void Main(string[] args)
	{
		
		Laptop laptop1 = new Laptop("laptop1", "desc of laptop1", "Windows", 4);
		Laptop laptop2 = new Laptop("laptop2", "desc of laptop2", "Linux", 32);
		
		Camera camera1 = new Camera("camera1", "desc of camera1", "brand1", 10);
		Camera camera2 = new Camera("camera2", "desc of camera2", "brand2", 20);
		
		Projector projector1 = new Projector("projector1", "desc of projector1", "type1", "1080p");
		Projector projector2 = new Projector("projector2", "desc of projector2", "type2", "720p");

		Student student1 = new Student("student_firstname1", "student_lastname1");
		Student student2 = new Student("student_firstname2", "student_lastname2");
		
		Employee employee1 = new Employee("employee_firstname1", "employee_lastname1");
		Employee employee2 = new Employee("employee_firstname2", "employee_lastname2");
		
		EquipmentService.AddEquipment(laptop1);
		EquipmentService.AddEquipment(laptop2);
		EquipmentService.AddEquipment(camera1);
		EquipmentService.AddEquipment(camera2);
		EquipmentService.AddEquipment(projector1);
		EquipmentService.AddEquipment(projector2);
		
		Console.WriteLine("Marking equipment as unavailable");
		EquipmentService.MarkAsUnavailable(laptop2);
		Console.WriteLine();
		
		Console.WriteLine("creating rentals for unavailable equipment and for student1 above students rental limit (2)");
		RentalService.CreateRental(student1, laptop1, 5);

		try
		{
			RentalService.CreateRental(student1, laptop2, 1);
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
		}
		
		RentalService.CreateRental(student1, camera1, 1);

		try
		{
			RentalService.CreateRental(student1, projector1, 1);
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
		}
		Console.WriteLine();
		
		
		Console.WriteLine("show all active rentals");
		RentalService.ActiveRentalsByUser(student1);

		Console.WriteLine("creating rental with late returnal date and assigning a fee");
		RentalService.CreateRental(employee1, camera2, 1);
		RentalService.Rentals[2].DueDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-5));
		RentalService.ReturnRental(employee1, camera2);
		//Console.WriteLine(RentalService.Rentals[2].DueDate);
		Console.WriteLine();
		
		Console.WriteLine("showing overdue rentals");
		RentalService.ShowOverdueRentals();
		Console.WriteLine();
		
		Console.WriteLine("creating report on equipment");
		EquipmentService.Report();
		Console.WriteLine();
	}
}