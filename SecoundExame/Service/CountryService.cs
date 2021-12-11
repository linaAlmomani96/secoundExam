using SecoundExame.Data;
using System.Collections.Generic;
using System.Linq;

namespace SecoundExame.Service
{
    public class CountryService: ICountryService
    {
        HRContext context;
        public CountryService(HRContext _context)
        {
            context = _context;
        }

        public List<Country> GetAll()
        {
            List<Country> countries = context.countries.ToList();
            return countries;
        }
    }
}