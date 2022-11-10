using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace DataAccess.DataAccessLayer
{
    public class GenderDataAccess
    {
        HOTELMANAGEMENT1_Context _Context = new HOTELMANAGEMENT1_Context();
        public List<GenderModel> GetAllGenders()
        {
            List<tblGender> genderList = _Context.tblGenders.ToList();
            List<GenderModel> genderListBo = new List<GenderModel>();
            foreach(tblGender gender in genderList)
            {
                GenderModel genderModel = new GenderModel
                {
                    Id = gender.Id,
                    Name = gender.Name,
                    ISACTIVE = gender.ISACTIVE
                };
                genderListBo.Add(genderModel);
            }
            return genderListBo;
        }
    }
}
