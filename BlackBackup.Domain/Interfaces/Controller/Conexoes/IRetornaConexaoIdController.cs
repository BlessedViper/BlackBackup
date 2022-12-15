using BlackBackup.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBackup.Domain.Interfaces.Controller.Conexoes
{
    public interface IRetornaConexaoIdController
    {
        Bucket RetornaConexaoId(int id);
    }
}
