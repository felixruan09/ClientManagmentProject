﻿using System;
using System.Threading.Tasks;
using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Services
{
    public interface IClientService
    {
        Task<Client> FindByIdAsync(int id);
        Task<IEnumerable<Client>> GetAllAsync();
        Task<Client> RegisterAsync(Client client);
        Task UpdateAsync(Client client);
        void Delete(int id);
    }
}
