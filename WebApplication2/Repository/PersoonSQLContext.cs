using MVCRepo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRepo.Repository
{
    /**
     * Fake database class om een persoon op te slaan en 
     * later weer op te halen.
     */
    public class PersoonSQLContext : IPersoonContext
    {
        PersoonModel pm;

        public void slaOp(PersoonModel persoon)
        {
            pm = persoon;
        }

        // Laad de persoon die is opgeslagen
        // Een speciaal geval is persoon met bsn 1712556789, die zal Pietje genoemd moeten worden
        public PersoonModel laadPersoon(int bsn)
        {            
            if (pm == null)
            { 
               pm = new PersoonModel();
            }

            if (bsn == 1712556789)
            {
                pm.Naam = "Pietje";
            }

            return pm;
        }
    }
}