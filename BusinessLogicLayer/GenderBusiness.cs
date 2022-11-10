using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccess.DataAccessLayer;

namespace BusinessLogicLayer
{
    public class GenderBusiness
    {
        GenderDataAccess gda = new GenderDataAccess();
        public List<GenderModel> GetAllGenders()
        {
            return gda.GetAllGenders();
        }
    }
}
