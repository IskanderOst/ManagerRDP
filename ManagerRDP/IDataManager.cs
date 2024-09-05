using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerRDP
{
    public interface IDataManager
    {
        
        RDPConnection AddRDP();
        RDPConnection EditRDP();
        RDPConnection DeleteRDP();

    }
}
