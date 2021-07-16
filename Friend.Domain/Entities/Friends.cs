using System;

namespace Friend.Domain.Entities
{
    public class Friends
    {
        public int Id { get; set; }

        public int IdUser { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string DDD { get; set; }

        public string Phone { get; set; }
        
        public string Adress { get; set; }

        public bool? Status { get; set; }

        public DateTime DTCreate { get; set; }

        public DateTime? DTUpdate { get; set; }
    }
}
