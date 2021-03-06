﻿using System.Threading.Tasks;

namespace core_server.Infrastructure.Security
{
    public interface IJwtTokenGenerator
    {
        Task<string> CreateToken(string username);
    }
}