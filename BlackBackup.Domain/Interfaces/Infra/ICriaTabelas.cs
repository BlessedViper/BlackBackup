using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBackup.Domain.Interfaces.Infra
{
    public interface ICriaTabelas
    {
        void CriaTabelasBd(string caminhoBanco);
    }
}
