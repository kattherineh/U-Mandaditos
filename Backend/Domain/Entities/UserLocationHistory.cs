namespace Domain.Entities;

public class UserLocationHistory
{
    public User User  { get; set; }
    public int IdUser { get; set; }
    
    public Location Location { get; set; }
    public int IdLocation { get; set; }
    
    public  DateTime CreatedAt { get; set; }
    
    public bool Active { get; set; }
}