using Rhetos.Mvc.Kadrovska;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Client.Repository
{
    public interface IDjelatnikRepository
    {
        Task<Djelatnik> GetDjelatnik(Guid Id);
        Task<List<Djelatnik>> GetDjelatnici();
    }
}
