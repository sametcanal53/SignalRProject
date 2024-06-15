using Microsoft.AspNetCore.Identity;

namespace SignalR.EntityLayer.Entities
{
    public class User : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
