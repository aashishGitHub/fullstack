using CookiesParadise;
using CookiesParadise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookiesRepository
{
    public interface ICookiesRepository
    {
        List<CookiesVm> GetAllCookies();
    }
}
