using System;

namespace Friend.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
                
        public string Name { get; set; }
        
        public string Email { get; set; }
        
        public string Document { get; set; }
        
        public string Password { get; set; }

        public DateTime DTCreate { get; set; }
        
        public DateTime? DTUpdate { get; set; }
    }
}
