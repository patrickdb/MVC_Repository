using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class AdresModel
    {
        public string Straat { get; }

        public AdresModel(string straat)
        {
            this.Straat = straat;
        }
    }
}