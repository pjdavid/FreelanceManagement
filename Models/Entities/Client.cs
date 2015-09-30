using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreelanceManagement.Models.Entities
{
    public class Client
    {
        [Key]
        public Guid Id { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Connector> Connectors { get; set; }
    }
}