using BlackBackup.Domain.Entities;

namespace BlackBackup.Domain.Interfaces.Infra
{
    public interface IIniciaBackupIaas
    {
        public bool IniciaTask(Instancia instancia);
    }
}
