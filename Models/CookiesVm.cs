using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CookiesParadise.Models
{
    public class CookiesVm
    {
        public int ID { get; set; }
        public string CookieName { get; set; }
        public int  NumberOfAvailableItems { get; set; }
        public int CookieTypeId { get; set; }
    }
}