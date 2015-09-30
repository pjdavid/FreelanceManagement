namespace FreelanceManagement.Models
{
    using System.Data.Entity;
    using Entities;

    public partial class Database : DbContext
    {
        public Database()
            : base("name=Database")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<ConnectorType> ConnectorTypes { get; set; }
        public DbSet<Connector> Connectors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
