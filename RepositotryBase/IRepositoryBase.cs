using Microsoft.EntityFrameworkCore;

namespace RepositoryBase
{
    public interface IRepositoryBase<TEntity, TContext> where TEntity : class where TContext : DbContext
    {
        TEntity SelecionarChave(params Object [] keyvalues);
        List<TEntity> Selecionartodos();
        void Incluir(TEntity entity);
        int Alterar(TEntity entity);
        void Excluir(TEntity entity);

    }
}