using BlazorMovies.Client.Helpers;
using Rhetos.Mvc.Kadrovska;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Client.Repository
{
    public class DjelatnikRepository : IDjelatnikRepository
    {
        private readonly IHttpService httpService;
        private string url = "http://localhost/KadrovskaBlazorRhetos/rest/Kadrovska/Djelatnik/";

        public DjelatnikRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Djelatnik>> GetDjelatnici()
        {
            var response = await httpService.Get<List<Djelatnik>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Djelatnik> GetDjelatnik(Guid Id)
        {
            var response = await httpService.Get<Djelatnik>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
    }
}
