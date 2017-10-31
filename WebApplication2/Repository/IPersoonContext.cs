using MVCRepo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCRepo.Repository
{
    interface IPersoonContext
    {
        void slaOp(PersoonModel persoon);

        PersoonModel laadPersoon(int id);
    }
}
