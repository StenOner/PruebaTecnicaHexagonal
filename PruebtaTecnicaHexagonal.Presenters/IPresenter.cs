namespace PruebtaTecnicaHexagonal.Presenters
{
    public interface IPresenter<T>
    {
        public T Content { get; }
    }
}
