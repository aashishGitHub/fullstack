using CookiesParadise;
using CookiesParadise.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CookiesRepository
{
    public class CookiesRepo : ICookiesRepository
    {
        public List<CookiesVm> GetAllCookies()
        {
            //var cookies = new IQueryable<Asis_Cookies>();
            // return null;
            using (var db = new Cookies())
            {             

               var allCookies = db.Asis_CookiesTypes.Select(x =>
               new CookiesVm
               {
                   ID = x.ID,
                   CookieName = x.CookiesType,
                   CookieTypeId = x.ID,
                   NumberOfAvailableItems = x.Asis_Cookies.Count
               });
                return allCookies.ToList();

            }
        }
    }
}
