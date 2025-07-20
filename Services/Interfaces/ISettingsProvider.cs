namespace Creator.ABA.Services.Interfaces
{
    public interface ISettingsProvider<T> where T : class, new()
    {
        public T Settings { get; }
        public void Save(string? filePath = null);
        public void Load(string? filePath = null);
    }
}
