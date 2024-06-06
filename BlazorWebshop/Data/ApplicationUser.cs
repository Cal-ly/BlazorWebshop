namespace BlazorWebshop.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? EnrollmentDate { get; set; }
    public DateTime? LastLogin { get; set; }
    public virtual Address? Address { get; set; }
    public string? AddressId { get; set; }
    public virtual ICollection<Order> Orders { get; set; } = [];
}
