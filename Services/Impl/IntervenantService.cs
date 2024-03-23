using Prj_Gestion_Evénement_UPF.DAO;
using Prj_Gestion_Evénement_UPF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Gestion_Evénement_UPF.Services.Impl
{
    public class IntervenantService : Service<Intervenant>
    {
        public IntervenantService(IDao<Intervenant> dao) : base(dao)
        {
        }
    }
}
