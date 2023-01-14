using KidsLearn.Shared.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsLearn.Shared.services
{
    public  interface ICountryService
    {
        Task<IEnumerable<Country>> GetCountries();
    }
}
