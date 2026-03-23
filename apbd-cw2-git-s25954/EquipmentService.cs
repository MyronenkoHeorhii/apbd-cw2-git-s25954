namespace apbd_cw2_git_s25954;

public class EquipmentService
{
    public static List<Equipment> Equipment { get; set; } = new List<Equipment>();

    public static void AddEquipment(Equipment equipment)
    {
        Equipment.Add(equipment);
    }

    public void GetEquipment()
    {
        foreach (Equipment equipment in Equipment)
        {
            Console.WriteLine(equipment.name + "; " + equipment.description + "; isAvailable: " + equipment.isAvailable);
        }
    }
    
    public static void GetAvailableEquipment()
    {
        foreach (Equipment equipment in Equipment)
        {
            if (equipment.isAvailable)
            {
                Console.WriteLine(equipment.name + "; " + equipment.description + "; isAvailable: " + equipment.isAvailable);
            }
        }
    }

    public static void MarkAsUnavailable(Equipment equipment)
    {
        equipment.isAvailable = false;
        Console.WriteLine("Unavailable: " + equipment.name);
    }

    public static void Report()
    {
        int totalEquipment = Equipment.Count;
        int availableEquipment = 0;
        int unavailableEquipment = 0;
        int laptopCount = 0;
        int cameraCount = 0;
        int projectorCount = 0;

        foreach (Equipment equipment in Equipment)
        {
            if (equipment.isAvailable)
            {
                availableEquipment++;
            }
        }
        
        foreach (Equipment equipment in Equipment)
        {
            if (!equipment.isAvailable)
            {
                unavailableEquipment++;
            }
        }

        foreach (Equipment equipment in Equipment)
        {
            if (equipment.GetType() == typeof(Laptop))
            {
                laptopCount++;
            }
        }
        
        foreach (Equipment equipment in Equipment)
        {
            if (equipment.GetType() == typeof(Camera))
            {
                cameraCount++;
            }
        }

        foreach (Equipment equipment in Equipment)
        {
            if (equipment.GetType() == typeof(Projector))
            {
                projectorCount++;
            }
        }
        
        Console.WriteLine("Total equipment: " + totalEquipment);
        Console.WriteLine("Available equipment: " + availableEquipment);
        Console.WriteLine("Unavailable equipment: " + unavailableEquipment);
        Console.WriteLine("Laptop count: " + laptopCount);
        Console.WriteLine("Camera count: " + cameraCount);
        Console.WriteLine("Projector count: " + projectorCount);
    }


}