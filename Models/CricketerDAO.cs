using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricketer.Models
{
    interface CricketerDAO
    {
        void AddCricketer(Cricketer cricketer);

        List<Cricketer> GetAllCricketers();

        Cricketer GetCricketer(int id);

        void DeleteCricketer(int id);

        void UpdateCricketer(Cricketer cricketer);
    }
}
