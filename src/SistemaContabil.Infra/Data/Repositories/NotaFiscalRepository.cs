using SistemaContabil.Core.Aggregates.Fiscal.Entities;
using SistemaContabil.Core.Aggregates.Fiscal.Repositories;

namespace SistemaContabil.Infra.Data.Repositories
{
    public class NotaFiscalRepository : Repository<NotaFiscalEntity>, INotaFiscalRepository
    {
        public NotaFiscalRepository(DataBaseContext dataBaseContext)
            :base(dataBaseContext)
        {
        }
    }
}
