namespace apbd_cw2_git_s25954;

public class EquipmentService
{
    public List<Equipment> Equipment { get; set; }

    public void AddEquipment(Equipment equipment)
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
    
    public void GetAvailableEquipment()
    {
        foreach (Equipment equipment in Equipment)
        {
            if (equipment.isAvailable)
            {
                Console.WriteLine(equipment.name + "; " + equipment.description + "; isAvailable: " + equipment.isAvailable);
            }
        }
    }

    public void MarkAsUnavailable(Equipment equipment)
    {
        equipment.isAvailable = false;
        Console.WriteLine("Unavailable: " + equipment.name);
    }
    
    
}