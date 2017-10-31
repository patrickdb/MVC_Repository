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
        // Het model bevat data die door de views in MVC getoond kan worden
        // Er is hier gekozen om de afhandeling van data via een technology
        // onafhankelijk implementatie te verlopen. (repository pattern)
        PersoonRepo cr = new PersoonRepo();

        [Required]
        public string Naam {
            get
            {
                // Haal de naam op uit de repository (engelse vertaling voor 'bewaarplaats').
                // Een repository wordt typisch gebruikt om data vast te leggen waar we 
                // bij een later bezoek aan de webpagina weer bij willen kunnen. Bijvoorbeeld
                // via een database.
                return cr.PersoonsNaam();
            }

            set
            {
                //throw new NotImplementedException();
                cr.ZetPersoonsNaam(value);
            }
        }
    }
}