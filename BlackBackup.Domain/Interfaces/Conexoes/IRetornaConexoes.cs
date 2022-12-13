using BlackBackup.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBackup.Domain.Interfaces.Conexoes
{
    public interface IRetornaConexoes
    {
        Task<List<Bucket>> RetornarConexoes();
    }
}
