using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Gestion_Evénement_UPF.DAO.Impl
{
    public class EvenementDao : Dao<Evenement>
    {
        public EvenementDao(DbContext context) : base(context)
        {
        }
    }
}
