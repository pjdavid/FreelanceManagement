namespace FreelanceManagement.Migrations
{
    using Models.Entities;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FreelanceManagement.Models.Database>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "FreelanceManagement.Models.Database";
        }

        protected override void Seed(FreelanceManagement.Models.Database context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            Client client1 = context.Clients.FirstOrDefault(c=>c.Name == "Client1");
            Connector connector1 = new Connector
            {
                ClientId = client1.Id,
                ConnectorType = context.ConnectorTypes.Find(1),//MailChimp
                UserName = "Client1",
                Password = "Password1"
            };
            context.Connectors.AddOrUpdate(connector1);

            Client client2 = context.Clients.FirstOrDefault(c => c.Name == "Client2");
            Connector connector2 = new Connector
            {
                ClientId = client2.Id,
                ConnectorType = context.ConnectorTypes.Find(1),//MailChimp
                UserName = "Client2",
                Password = "Password2"
            };
            context.Connectors.AddOrUpdate(connector2);

            Client client3 = context.Clients.FirstOrDefault(c => c.Name == "Client3");
            Connector connector3 = new Connector
            {
                ClientId = client3.Id,
                ConnectorType = context.ConnectorTypes.Find(2),//GMAIL
                UserName = "Client3",
                Password = "Password3"
            };
            context.Connectors.AddOrUpdate(connector3);
        }
    }
}
