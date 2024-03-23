using Prj_Gestion_Evénement_UPF.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Gestion_Evénement_UPF.Services.Impl
{
    public class EvenementService : Service<Evenement>
    {
        public EvenementService(IDao<Evenement> dao) : base(dao)
        {
        }
    }
}
