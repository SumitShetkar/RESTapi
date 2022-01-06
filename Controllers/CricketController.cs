using Cricketer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cricketer.Controllers
{
    public class CricketController : ApiController
    {

        CricketerDAOImpl impl;

        public CricketController()
        {
            impl = Factory.GetCricketerDAOImplInstance();
        }

        public List<Cricketer.Models.Cricketer> GetAll()
        {
            return impl.GetAllCricketers();
        }

        public Cricketer.Models.Cricketer Get(int id)
        {
            return impl.GetCricketer(id);
        }

        public void Delete(int id)
        {
            impl.DeleteCricketer(id);
        }

        public void Post([FromBody] Cricketer.Models.Cricketer cricketer)
        {
            impl.AddCricketer(cricketer);
        }

        public void Put([FromBody] Cricketer.Models.Cricketer cricketer)
        {
            impl.UpdateCricketer(cricketer);
        }
    }
}
