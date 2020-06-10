using Gljivar.Models;
using System;

namespace My.Model.DatabaseConnector
{
   public interface IDbFactory : IDisposable
    {
        GljivarContext Init();
    }
}
