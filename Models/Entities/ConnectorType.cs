using System.ComponentModel.DataAnnotations;

namespace FreelanceManagement.Models.Entities
{
    public class ConnectorType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }
    }
}