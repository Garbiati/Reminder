using System;
using System.ComponentModel.DataAnnotations;

namespace Reminder.Domain.Entities
{
    public class ReminderType
    {
        public int ReminderTypeId { get; set; }

        [Required]
        public string Name { get; private set; }

        [Required]
        public string Description { get; private set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public ReminderType(string name, string description)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }
    }
}
