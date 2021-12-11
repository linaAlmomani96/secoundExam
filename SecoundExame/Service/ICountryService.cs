using SecoundExame.Data;
using System.Collections.Generic;

namespace SecoundExame.Service
{
    public interface ICountryService
    {
        List<Country> GetAll();
    }
}