using Prj_Gestion_Evénement_UPF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Gestion_Evénement_UPF.DAO.Impl
{
    public class IntervenantDao : Dao<Intervenant>
    {
        public IntervenantDao(DbContext context) : base(context)
        {
        }
    }
}
