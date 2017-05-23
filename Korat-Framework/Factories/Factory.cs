namespace KoratFramework.Factories
{
    public abstract class Factory<T>
    {
        public abstract T Make(string app);
    }
}
