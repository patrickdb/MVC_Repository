using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MVCRepo.Repository;

namespace MVCRepo.Models
{
    public class PersoonModel
    {
        public int BSN { get; set; }

        public String Naam { get; set; }
    }
}