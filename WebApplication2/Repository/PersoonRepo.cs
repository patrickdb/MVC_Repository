using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCRepo.Repository;

namespace MVCRepo.Repository
{
    public class PersoonRepo
    {
        IPersoonContext pc = new PersoonSQLContext();

        internal string PersoonsNaam ()
        {
            //throw new NotImplementedException();
            return "";
        }

        internal void ZetPersoonsNaam(string naam)
        {
            //throw new NotImplementedException();
            naam = "Piet";
        }
    }
}