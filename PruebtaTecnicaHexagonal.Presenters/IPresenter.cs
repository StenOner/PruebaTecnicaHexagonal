namespace PruebaTecnicaHexagonal.Presenters
{
    public interface IPresenter<T>
    {
        public T Content { get; }
    }
}
