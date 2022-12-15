using BlackBackup.Domain.Entities;
using BlackBackup.Domain.Interfaces.Conexoes;
using BlackBackup.Domain.Interfaces.Controller.Conexoes;
using BlackBackup.Infra;
using BlackBackup.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackBackup.Controller.Conexoes
{
    public class EditarConexaoController : IEditarConexaoController
    {
        public IEditarConexao EditarConexaoInfra { get; set; }
        private DataSQLiteContext _context;
        public void EditarConexao(Bucket bucket)
        {
            _context = new DataSQLiteContext();
            EditarConexaoInfra = new EditarConexao(_context);
            EditarConexaoInfra.Editar(bucket);
        }
    }
}
