﻿using System;
using System.Threading.Tasks;
using Application.Dtos;
using Application.Interfaces;

namespace Application.CreateClient
{
    public class CreateClientUseCase : ICreateClientUseCase
    {
        public CreateClientUseCase()
        {

        }

        public Task<bool> CreateClient(ClientDto client)
        {
            throw new NotImplementedException();
        }
    }
}
