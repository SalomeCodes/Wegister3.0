namespace Application.Common.Factories.Interfaces
{
    public interface IFactory<TEntity, TViewModel>
        where TEntity : class where TViewModel : class
    {
        public TViewModel Create(TEntity entity);
    }
}
