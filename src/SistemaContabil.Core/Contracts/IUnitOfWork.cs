namespace SistemaContabil.Core.Contracts
{
    public interface IUnitOfWork
    {
        bool Commit();

        void Dispose();

        void RollBack();
    }
}
