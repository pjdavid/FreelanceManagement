using FreelanceManagement.Models;
using FreelanceManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FreelanceManagement.Services
{
    public class ClientService
    {
        
        public IEnumerable<Client> GetListOfClient(int userId)
        {
            var database = new Database();
            var data = database.Clients.Where(c => c.UserId == userId);

            return data;
        }

        internal object GetClientByData(Guid clientId)
        {
            var database = new Database();
            var data = database.Clients
                        .FirstOrDefault(c => c.Id == clientId);

            return data;
        }
    }
}