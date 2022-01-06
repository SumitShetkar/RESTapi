using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cricketer.Models
{
    public class Factory
    {

        public static CricketerDAOImpl GetCricketerDAOImplInstance() 
        {
            return CricketerDAOImpl.GetCricketerDAOImplInstance(); 
        }

        public static CricketServiceDAOImpl GetCricketServiceDAOImplInstance()
        {
            return CricketServiceDAOImpl.GetCricketServiceDAOImplInstance();
        }
    }
}