namespace WalletPlus.Web.Data.Entities
{
    public abstract class BaseEntities<TKey>
    {
        public Guid Id { set; get; }
    }
}
