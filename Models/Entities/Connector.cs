using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreelanceManagement.Models.Entities
{
    public class Connector
    {
        [Key]
        public int Id { get; set; }

        public Guid ClientId { get; set; }

        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public virtual ConnectorType ConnectorType { get; set; }

    }
}