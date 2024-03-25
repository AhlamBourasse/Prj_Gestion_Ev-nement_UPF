using Prj_Gestion_Evénement_UPF.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Gestion_Evénement_UPF.Services.Impl
{

    public class ParticipantService : Service<Participant>
    {
        public ParticipantService(IDao<Participant> dao) : base(dao)
        {
        }

    }
}
