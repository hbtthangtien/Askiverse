using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Notification
    {
        public int Id { get; set; }

        public string? SenderId { get; set; }

        public string? ReceiverId { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public bool IsRead { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual BasicUser? Receiver { get; set; }

        public virtual BasicUser? Sender { get; set; }
    }
}
