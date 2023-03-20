using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SlunchevIzgrev.Data
{
    public class User:IdentityUser
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public DateTime Register_On { get; set; }
       public ICollection<Reservation> Reservations { get; set; }
    }
}
