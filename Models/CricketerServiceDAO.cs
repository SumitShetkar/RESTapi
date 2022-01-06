using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricketer.Models
{
    interface CricketerServiceDAO
    {
        void AddCricketer();

        void GetAllCricketers();

        void GetCricketer();

        void DeleteCricketer();

        void UpdateCricketer();
    }
}
