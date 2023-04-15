namespace ClothingShopApi.Abstract.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        TEntity[] GetAll();
        void Add(TEntity entity);
        void Remove(TEntity entity);
    }
}
